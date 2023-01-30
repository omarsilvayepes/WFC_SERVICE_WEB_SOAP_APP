# Project Title

Service Web SOAP

## Description

Service SOAP web application for expone two basic test services that are consume for client Web API ( API REST)

## Getting Started

Enable windows comunication foundation wcf inside the visual studio  installer for use the template.

Create (expone) service soap

1-select template wcf service application
2-the service soap is implement int class service1.svc that use the interface Iservice.cs
3-if you need add extra service soap to the project , select option add, new item  and choose  template wcf service application

Consume service soap 


1-add new project to repository
2-in the client project select right click and select the options: Add-Service reference -WFC web service
3-click in the button discover and check the services implemented
4-put name to reference service
5-create client for consume the service soap (Note: for run  in localost in requiremnt in the client project, select debug option in the project and then start a new instance option)
6- for update the web service soap , repeat the steps 2 until 4 using the same name  

### Dependencies


### Executing program


```
code blocks for commands
```

## Help


* The application as well runs on localhost  (https://localhost:7234/myServiceSoap) and is   tested with Postman , Swagger or any API testing platform.

* Application EndPoints for test it:

GET:

* https://localhost:7234/myServiceSoap

```

## Authors

Omar Silva Yepes 
[@Omar](omar.yepes@hotmail.com)

## Version History

* 0.1
    * Initial Release

## Additional Information
