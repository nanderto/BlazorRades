# BlazorRades
Azure Portal Blades type functionality

Created a separate project for the Client side and the web host, "BlazorRadesWeb" it still uses the BlazorRades component but it was so different from server side it made sense to create something new. Perhaps later it will become apparent what the similarities are.

The solution is the BlazorRadesWeb\BlazorRadesWeb.sln

The CalibrationCasesListViewModel calls a service which calls the http endpoint provided by the api. This is the only WebApi that is being used to prove how to do it. Still alot to add from additional endpoints to security, this is just a prof of conmcept and maily proves that Client Side definitly needs to call an API to interact with the server (cant use the dame code as previousl written for Servers Side where the link to the server is managed automatically.


