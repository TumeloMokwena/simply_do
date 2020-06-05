# simply_do
A To Do app written in Xamarin.Android (Native)

Project information

Author: Tumelo Titus Mokwena 
Website: https://tumelomokwena.com 
Email: tumelo@tumelomokwena.com / ttyanini@gmail.com
App Name: Simply Do - To Do List app ** Platform: Xamarin.Android (Native)

Getting Started
Clone the code repository from the link provided: git clone https://github.com/TumeloMokwena/simply_do.git
Ensure you are running Visual Studio 2019 - build (16.3.3 or higher)
Part of support libraries, the solution uses MVVMCross 6.1.2 - ensure it is installed into the solution using Nuget Package Manager to be able to build.
See last section for instructions on how to clone
Project architecture
The solution consists of four projects; a. TO_DO : A native Android application project consisting of all native Android libraries (User Interface project) b. TO_DO.ViewModels : All view models used by the application and related logic c. TO_DO.Models : Data entities/objects used by the application d. TO_DO.DataRepository : Consists of a repository manager which handles all storage CRUD operations

Architecture I went with is MVVM, approach uses ViewModel to ViewModel navigation meaning ViewModel first needs to be initialized then it evokes its related activity then view.

Within ViewModel solution, App.cs has IoC which initializes the application and injects an extended splash screen to be loaded as soon as the application starts up.
Models is a centralized solution as it is referenced by ViewModels, DataRepository and the UI project.

What's missing:
1. Binding checkboxes to item IsCompleted field
2. Binding progress bar % status and progress bar indicator
3. Delete function is writed and not mapped.
4. Add functionality needs to be fixed.

