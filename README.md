# UserManagementAPI
這是一個用於管理使用者的 API，使用 .NET 8 和 Entity Framework Core 進行開發。

## 目錄

- [專案結構](#專案結構)
- [安裝](#安裝)
- [使用方法](#使用方法)
- [API 端點](#api-端點)
- [資料庫遷移](#資料庫遷移)
- [資料表語法參考](#資料表語法參考)

## 專案結構
```
Project root 
├── UserManagementAPI/ 
│   ├── Controllers/ 
│   │   └── UserController.cs 
│   ├── SQL
│   │    └──script.sql
│   └── UserManagementAPI.csproj
├── DataAccess/ 
│   ├── Migrations/ 
│   ├── Repository/ 
│   ├── UserDbContext.cs 
│   └── DataAccess.csproj 
├── Model/ 
│   ├── Domain/ 
│   └── DTO/ 
├── UserManagementAPI.sln/
└── README.md
```
## 安裝

1. 克隆此儲存庫：
    ```bash
    git clone https://github.com/YCNaclptz/UserManagementAPI.git
    ```
2. 進入專案目錄：
    ```bash
    cd UserManagementAPI
    ```
3. 還原 NuGet 套件：
    ```bash
    dotnet restore
    ```
## 使用方法

1. 更新 `appsettings.json` 以配置您的資料庫連接字串。

2. 應用資料庫遷移：
    ```bash
    dotnet ef database update
    ```
3. 啟動 API：
    ```bash
    dotnet run
    ```
## API 端點

### 使用者管理

- `GET /api/User/GetUsers` - 獲取使用者列表
- `GET /api/User/Summary` - 獲取使用者摘要彙總
- `POST /api/User/RegisterUser` - 註冊新使用者

## 資料庫遷移

若要創建新的遷移，請使用以下命令：
```bash
dotnet ef migrations add  "新的遷移"
```
更新資料庫：
```bash
dotnet ef database update
```
## 資料表語法參考
位於
```
Project root/UserManagementAPI/SQL/script.sql
```

