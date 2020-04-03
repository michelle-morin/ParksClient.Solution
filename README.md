# Parks Client

#### _MVC application that interacts with Parks Lookup API_

#### By: **Michelle Morin**, April 3, 2020

## Description

_This MVC application interacts with a custom-built Parks Lookup API, allowing users to GET, POST, PUT, and DELETE park entries._

## Specification user stories:
| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| If user visits '/' root route, the application displays a splash page with links to '/Parks' and '/Users' | user visits '/' route | application displays homepage |
| Application allows a user to register for an account with Identity | user clicks "login/register" option on splash page, then completes form at '/Account/Register' | application creates new user account and redirects to '/Login' |
| Application allows a registered user to login | registered user clicks "log in" option at '/Account' | application redirects to '/Account/Login' |
| Application allows a registered user to logout | registered user clicks "logout" option at '/Account' | application logs out of user account |
| Only registered, logged-in users are able to create, update, and delete parks | user is not logged in and/or not registered and clicks "add park", "edit park", or "delete park" | user redirected to login page |
| If user visits '/Parks' route, the application displays all parks obtained from Parks Lookup API, ordered alphabetically by park name | user visits '/Parks' | application displays sorted list of all parks |
| If a registered user clicks "add new park" link at '/Parks', the application redirects to a form ('/Parks/Create') for adding a new park | registered user clicks "add new park" | the application redirects to form at 'Parks/Create' |
| When a registered user submits the new park form, the application creates the new park entry and redirects to '/Parks' | registered user submits new park form | the application adds new park to parks table and redirects to '/Reviews' |
| A registered user can delete a park from the list of all parks | registered user selects "delete park" option | application deletes park from database |
| A registered user can edit a park from the list of all parks | registered user selects "edit park" | application redirects to edit form |

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Install MySQL and MySQL Workbench

#### on macOS:
_Download the MySQL Community Server DMG File [here](https://dev.mysql.com/downloads/file/?id=484914). Follow along with the installer until you reach the configuration page. Once you've reached Configuration, set the following options (or user default if not specified):_
* use legacy password encryption
* set password (and change the password field in appsettings.json file of this repository to match your password)
* click finish
* open Terminal and enter the command ``echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`` if using Git Bash.
* Verify MySQL installation by opening Terminal and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. If you gain access to the MySQL command line, installation is complete. An error (e.g., -bash: mysql: command not found) indicates something went wrong.

_Download MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391). Install MySQL Workbench to Applications folder. Open MySQL Workbench and select Local instance 3306 server, then enter the password you set. If it connects, you're all set._

#### on Windows:
_Download the MySQL Web Installer [here](https://dev.mysql.com/downloads/file/?id=484919) and follow along with the installer. Click "Yes" if prompted to update, and accept license terms._
* Choose Custom setup type
* When prompted to Select Products and Features, choose the following: MySQL Server (Will be under MySQL Servers) and MySQL Workbench (Will be under Applications)
* Select Next, then Execute. Wait for download and installation (can take a few minutes)
* Advance through Configuration as follows:
  - High Availability set to Standalone.
  - Defaults are OK under Type and Networking.
  - Authentication Method set to Use Legacy Authentication Method.
  - Set password to epicodus. You can use your own if you want but epicodus will be assumed in the lessons.
  - Unselect Configure MySQL Server as a Windows Service.
* Complete installation process

_Add the MySQL environment variable to the System PATH. Instructions for Windows 10:_
* Open the Control Panel and visit _System > Advanced System Settings > Environment Variables..._
* Select _PATH..._, click _Edit..._, then _Add_.
* Add the exact location of your MySQL installation and click _OK_. (This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation.)
* Verify installation by opening Windows PowerShell and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. It's working correctly if you gain access to the MySQL command line. Exit MySQL by entering the command ``exit``.
* Open MySQL Workbench and select Local instance 3306 server (may be named differently). Enter the password you set, and if it connects, you're all set.

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone https://github.com/michelle-morin/ParksClient.Solution``
* ``cd ParksClient.Solution/ParksClient``

_Confirm that you have navigated to the ParksClient directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

## Clone the Parks Lookup API repository and run the Parks Lookup API

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd ~``
* ``cd desktop``
* ``git clone https://github.com/michelle-morin/ParksLookup.Solution``
* ``cd ParksLookup.Solution/ParksLookup``
* ``dotnet run`` or ``dotnet watch run``

## Run this MVC application in another Terminal or PowerShell window

_Run this MVC application by entering the following command in Terminal (macOS) or PowerShell (Windows) at the root of the ParksClient directory:_
* ``dotnet run`` or ``dotnet watch run``

_To view/edit the source code of this application, open the contents of the ParksClient.Solution directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal at the root of the ParksClient.Solution directory)._

## Technologies Used

* GitBash
* Git
* C#
* ASP.NET Core MVC 2.2
* dotnet script 0.50.1
* MySQL 8.0.15
* Entity Framework Core 2.2
* Identity
* RestSharp version 106.6.10
* Newtonsoft.Json version 12.0.2
* Parks Lookup API version 1.0 (https://github.com/michelle-morin/ParksLookup.Solution)

## License

Licensed under the MIT license.

&copy; 2020 - Michelle Morin