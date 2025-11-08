# Hotel Management System (C#)

A desktop Hotel Management System implemented in C#. This README keeps project and code information up-to-date and describes features, how the code is organized, how to build/run the project, and how to maintain or extend it.
 This project was developed for the course Object Oriented Programming-2 (C#) by the students of American International University-Bangladesh (AIUB) and guided by SAIKAT BAUL, LECTURER,AIUB. Team members are - @UDDIN, MD.ALFAZ @SHAMIM, MD. SHAFAYAT HOSSAIN @RIYAD, KAZI FARDIN RAHMAN @BHOWMICK, PRONOY KANTI 

> NOTE: This document assumes the repository root contains a Visual Studio solution (.sln) and one or more C# project files (.csproj). If your layout differs, adjust paths accordingly.

## Project overview

This project implements core hotel operations such as room and reservation management, guest check-in/check-out flows, invoicing, and simple reporting. It is designed as a learning/example project and a starting point for a small hotel's desktop management system.

## Features

- Reservation management: create, update, cancel reservations; view reservation calendar
- Check-in / Check-out: assign rooms at check-in, mark rooms available on check-out
- Billing & Invoicing: generate bills and invoices for stays, charges
- Reporting: occupancy reports, revenue reports, date-range summaries
- Data persistence: relational database support (used Microsoft SQL server)
- Basic validation and error handling in UI and data layer

## Codebase overview (code info)

This section explains how the code is typically organized and where to find important components. If your repository deviates from this convention, adjust the paths below.

- Solution & projects
  - Root: contains the Visual Studio solution file (*.sln) and one or more project folders.
  - Main application project: usually a folder like `HotelManagement` or `HotelManagementSystem` containing the UI and entry point (Program.cs).
      
- Entry points
  - For WinForms: Program.cs -> Application.Run(new MainForm())
  - For Console: Program.cs -> Main(string[] args)

- Key files to inspect first
  - *.sln — solution file that ties projects together.
  - *.csproj — project settings and package references.
  - Program.cs — application entry point and configuration bootstrap.
  - app.config or appsettings.json — connection strings and runtime configuration.
  - /database/schema.sql or /sql/* — DDL and seed data scripts.

## Tech stack

- Language: C# (check .csproj TargetFramework for exact version)
- UI: WinForms / WPF / Console (project-specific)
- Data: Microsoft SQL server (configurable via connection string)
- Tools: Visual Studio or VS Code with C# extensions, dotnet CLI

## Prerequisites

- Windows OS for desktop UI (WinForms/WPF)
- Visual Studio 2019/2022 (or newer) or dotnet SDK matching the project's target framework
- Microsoft SQL server
- Git for source control

## Installation & build

1. Clone the repository:
   git clone https://github.com/alfaaz-uddin/Hotel-Management-System-C-Sharp.git

2. Open the solution:
   - Double-click the `.sln` in Visual Studio, or
   - Open the folder in VS Code for SDK-style projects.

3. Restore dependencies:
   - Visual Studio restores NuGet packages automatically.
   - Or run: dotnet restore (for SDK-style projects)

4. Build:
   - Visual Studio: Build -> Build Solution
   - CLI: dotnet build

## Database setup

Upload the SQL.

## Configuration


## Running the application

- Visual Studio
  - Right-click the startup project -> Set as Startup Project
  - Press F5 (Debug) or Ctrl+F5 (Run without debugging)

- Command line (SDK-style)
  - cd to project folder containing the .csproj
  - dotnet run

## Contributing

- Fork repository and create feature branches.
- Run and validate the application locally.
- Add or update tests where applicable.
- Open pull requests with a description of the change and any migration steps.

## Issues & Support

- Use GitHub Issues to file bugs or feature requests. Include steps to reproduce, environment details, and logs/screenshots.

## License

Under MIT License.

## Contact

Maintainer: alfaaz-uddin (GitHub)
