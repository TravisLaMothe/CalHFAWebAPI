# CSC-131 CalHFA Web API Project

 

## Description

The project aim is to create a web API to automate the process of updating and displaying loan information analytics with a variety of different calls. The goal is to free the marketing team of the responsibility of manually maintaining loan information on the agency’s public facing website. The API will be accessed by community users where they will get access to information like financial data. The program will update itself with new data every 2 weeks from a hosted server.

## General Information

### Terminology

* CalHFA - California Housing Finance Agency
* AWS - Amazon Web Services
* SQL - Structured Query Language, programming language used commonly by databases and data stream management systems
* API - Application Programming Interface, connection between computers or computer programs. An interface that offers services to other pieces of software.
* REST - Representational state transfer
* HTTP - Hypertext Transfer Protocol
* CSV - Comma Separated Values

### Project Background

* Client’s background: California Housing Finance Agency supports the needs of renters.
* Expectations: A consumable API with a variety of calls to display loan information analytics. Utilize own resources. Provide full documentation of design and specifications of the system. 
* Business Need: Automate static web part which displays aggregate loan processing information that is updated twice a week. This allows the marketing team to focus their efforts and time elsewhere. 


### Users

* Clients: Any person who accesses the front facing data on CALHFA’s website.
* Marketing team: Automate data to have the marketing team use less time maintaining a static webpage.
* IT department: Automate data acquiring so less IT time is used for manual data extracts.

## Functional Requirements

### Data Retrieval 
Receive client requests for what they are searching for.
Client should know some key data that they are looking for so the program can look for the reliant data.
		
### Data search and retrieval
The program should retrieve relevant data for clients' requests.
With clients input the program can search for the data they are looking for.

### Display Data
Then it should be able to display the data in an easy to read way for the clients use.
It should also be able to display an error code if something went wrong or if the client entered invalid search parameters.

## Deployment

### Testing With Better Dragon's Test Data
The code can be forked from this GitHub and tested on local environments connecting to our database. CalHFA can use this to test to make sure the code works before using live SQL server data.

### Switching From Our Data To Live Data
To switch from MySQL to SQLServer, chang the database connection values in /constants/DatabaseConstants.cs under the SQLSERVER_ prefix. Set USE_MYSQL to false in the same file.

### Example of API Consumption
            $.getJSON('https://calhfaapi.azurewebsites.net/api/closingloans', function(data) {
                $("#ComplianceLoansInLine")[0].innerHTML = data[0].Count;
                var date = new Date(data[0].Date.replaceAll("-", "/"));
                var options = {  month: 'short', day: 'numeric', /*year: 'numeric'*/ };
                $("#ComplianceDate")[0].innerHTML = date.toLocaleString("en-US", options);

                $("#SuspenseLoansInLine")[0].innerHTML = data[1].Count;
                date = new Date(data[1].Date.replaceAll("-", "/"));
                $("#SuspenseDate")[0].innerHTML = date.toLocaleString("en-US", options);
            });


## Authors

* Team Lead [Joseph B](https://github.com/Joemeister52)
* Project Manager [Carlena S](https://github.com/carlenacodes)
* Programming Lead [Travis L](https://github.com/TravisLaMothe)
* Project Auditor [Tim C](https://github.com/Timmay21)
* Software Engineer [Tim H](https://github.com/thuang0)
* Software Engineer [Bryant G](https://github.com/Bryant89)
* ~~Lead Researcher [Elijah G](https://github.com/elijahg731)~~ Left group as he moved states
