# LinkHub Bookmark

LinkHub Bookmark is a Blazor Server web application for managing personal bookmarks with user authentication. Users can register, log in, and organize their bookmarks by categories. The app supports adding, searching, filtering, and deleting bookmarks, and each user's data is kept private.

## Features

- User registration and login (ASP.NET Core Identity)
- Add, edit, and delete bookmarks
- Organize bookmarks by custom categories
- Search and filter bookmarks by title and category
- using PostgreSQL Database - check through TablePlus

## Tech Stack

- ASP.NET Core Blazor Server
- ASP.NET Core Identity (authentication & authorization)
- PostgreSQL Database - check through TablePlus

## Live code

https://blazor-subinchoo-app-f9gwh8egbchvddg8.australiaeast-01.azurewebsites.net/ 

## Getting Started

1. **Install dependencies:**
   - [.NET 8 SDK or later](https://dotnet.microsoft.com/download)
1.2 - **Install PostgreSQL**
   Download from: https://www.postgresql.org/download/
   Mac: Use Postgres.app or Homebrew
   Windows: Use the official installer
   Make sure PostgreSQL is running and note:
   
   ✅ Port (default is 5432)
   ✅ Username (e.g. postgres)
   ✅ Password
   ✅ Database name (e.g. LinkHubDb)


2. **Go to the LinkHub folder**
   ```sh
   cd LinkHub
   ```
3. **restore the dotnet**
   ```sh
   dotnet restore
   ```
4. **Apply database migrations:**
   ```sh
   dotnet ef database update
   ```
5. **Run the app:**
   ```sh
   dotnet run
   ```
6. Open your browser at [https://localhost:****] (the URL shown in the terminal).

## Project Structure

- `Pages/` - Main Blazor pages and components
- `Areas/Identity/` - Identity UI for authentication
- `Data/` - ApplicationDbContext and EF Core setup
- `LinkItem.cs` - Model for bookmarks

## License

MIT License
