cd ../../..

cd src/tasks/402950-InsertGuid

cd src/apps/402950-InsertGuid

## The following is working
dotnet build ./InsertGuid.csproj

## The following is working
dotnet build ./InsertGuid.sln

## The following is working
devenv /build Debug ./InsertGuid.sln

## The following is NOT working.
## I am getting the following error message

## Unable to run your project.
## Ensure you have a runnable project type and ensure 'dotnet run' supports this project.
## A runnable project should target a runnable TFM (for instance, net5.0) and have OutputType 'Exe'.
## The current OutputType is 'Library'.

dotnet run /RootSuffix Exp ./InsertGuid.csproj


# If you just want to start and run visual studi in experimental mode, run the following command.
# I dont how to run this with PreView Version. 
devenv.exe /RootSuffix Exp ./InsertGuid.sln

pwd

Get-ChildItem

cd bin/debug

Get-ChildItem

cd net7.0-windows

Get-ChildItem

# Now to install the extension, first ensure all the instances of Visual Studio are closed.
# Now simply run the following command to install the extension

./InsertGuid.vsix

# Once installed, open the logs. You will see something like. 
# YourUserName should be replaced with your user name. 
# The extension has been installed to C:\Users\YourUserName\AppData\Local\Microsoft\VisualStudio\17.0_c9ef2fd3\Extensions\fyp2abr3.n2t\

## https://github.com/microsoft/VSExtensibility/issues/258
