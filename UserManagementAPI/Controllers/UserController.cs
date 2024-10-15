using DataAccess;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Domain;
using Model.DTO;
using System.Text;

namespace UserManagementAPI.Controllers
{
    /// <summary>
    /// 控制器來管理使用者相關的 API 操作。
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// 初始化 UserController 類別的新執行個體。
        /// </summary>
        /// <param name="unitOfWork">單位工作模式的實例</param>
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        /// <summary>
        /// 取得所有使用者，並根據提供的篩選條件、排序條件和分頁參數進行篩選和排序。
        /// </summary>
        /// <param name="name">使用者名稱的篩選條件</param>
        /// <param name="minAge">使用者最小年齡的篩選條件</param>
        /// <param name="maxAge">使用者最大年齡的篩選條件</param>
        /// <param name="gender">使用者性別的篩選條件（0 表示男，1 表示女）</param>
        /// <param name="sortBy">排序的欄位名稱</param>
        /// <param name="isAscending">是否為升冪排序</param>
        /// <param name="pageNumber">頁碼，預設為 1</param>
        /// <param name="pageSize">每頁的大小，預設為 10</param>
        /// <returns>包含使用者資料的結果</returns>
        [HttpGet("GetUsers")]
        public async Task<IResult> GetAll([FromQuery] string? name, [FromQuery] int? minAge, [FromQuery] int? maxAge, [FromQuery] int? gender, [FromQuery] string? sortBy, [FromQuery] bool isAscending, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var usersDomainModel = await _unitOfWork.User.GetUsers(name, minAge, maxAge, gender, sortBy, isAscending, pageNumber, pageSize);

            var usersDTO = usersDomainModel?.Select(user => new UserDto
            {
                Name = user.Name,
                Email = user.Email,
                Age = user.Age,
                Gender = user.Gender,
                Location = new Location
                {
                    Province = user.Province,
                    City = user.City
                }
            });
            return Results.Ok(usersDTO);
        }
        /// <summary>
        /// 取得使用者的彙總資訊。
        /// </summary>
        /// <returns>包含使用者彙總資訊的結果</returns>
        [HttpGet("Summary")]
        public async Task<IResult> GetUserSummary()
        {
            var userSummary = await _unitOfWork.User.GetUserSummary();
            return Results.Ok(userSummary);
        }
        /// <summary>
        /// 新增一個使用者。
        /// </summary>
        /// <param name="addUserRequestDto">包含新增使用者資料的 DTO</param>
        /// <returns>包含新增使用者資料的結果</returns>
        [HttpPost("RegisterUser")]
        public async Task<IResult> Create(AddUserRequestDto addUserRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return Results.BadRequest(ModelState);
            }

            Gender genderEnum;
            if (addUserRequestDto.Gender == "男")
            {
                genderEnum = Gender.Male;
            }
            else if (addUserRequestDto.Gender == "女")
            {
                genderEnum = Gender.Female;
            }
            else
            {
                return Results.BadRequest("性別必須是 '男' 或 '女'");
            }
            var domainModel = new User
            {
                Name = addUserRequestDto.Name,
                Email = addUserRequestDto.Email,
                Age = addUserRequestDto.Age,
                Gender = genderEnum,
                Password = addUserRequestDto.Password,
                Province = addUserRequestDto.Province,
                City = addUserRequestDto.City
            };
            try
            {
                await _unitOfWork.User.CreateAsync(domainModel);
                await _unitOfWork.SaveAsync();
            }
            catch (DbUpdateException dbUpdEx)
            {
                if (dbUpdEx.InnerException?.Message?.StartsWith("Violation of PRIMARY KEY constraint") ?? false )
                {
                    return Results.BadRequest($"新增使用者失敗！該Email已申請過");
                }
                if (dbUpdEx.InnerException?.Message?.StartsWith("The INSERT statement conflicted with the FOREIGN KEY constraint") ?? false)
                {
                    return Results.BadRequest($"新增使用者失敗！請確認地區是否存在");
                }
                return Results.BadRequest($"新增使用者失敗！");
            }
            catch (Exception)
            {
                return Results.BadRequest($"新增使用者失敗！");
            }
            var userDto = new UserDto
            {
                Name = domainModel.Name,
                Email = domainModel.Email,
                Age = domainModel.Age,
                Gender = domainModel.Gender,
                Location = new Location
                {
                    City = domainModel.City,
                    Province = domainModel.Province
                }
            };
            return Results.Ok(userDto);
        }
    }
}
