# Dockerised DotNet Web API and MSSQL Db 

This is a simple app to test and demonstrate how to: 
1. Containerize a web app 
2. Containerize a MSSQL sql server local db instance
3. Use docker compose to create a shared network and facilitate communication between the applications 


## Getting Started 
You will need to create a .env file in the same directory as the docker-compose.yml file. 

You will need to set the password for sql server: 

MSSQL_SA_PASSWORD={REPLACE-WITH-A-STRONG-PASSWORD}