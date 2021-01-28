# Example - GUI application + WCF Service hosted in Windows Service + Installer

This example includes:

* A Windows Service
* A WCF Service hosted in Windows Service
* A WinForms application which calls methods of the WCF service
* An installer which installs windows service and the WinForms application and put the application in startup.

This is the rational begind the projects:

* Separating the services of the application from UI. 
* Running services as Windows Service.
* Running (a Windows Forms Application) after user login. 
* To communicate between the service and the windows Application, self-hosted WCF has been used.
* The installer makse the deployment easier by installing and configuring windows service and the application and startup.

As a result, after installation the service will be started in windows startup. The GUI application also will start when user logs into the application. Then if you click on a button it will show a message from service.