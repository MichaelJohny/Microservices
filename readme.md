# Microservices

## Run

### Prerequisites

* [Docker](https://www.docker.com/get-started)

### Steps

Execute **docker-compose up --build -d** in root directory.

### Scale

Execute **docker-compose up --build -d --scale customer-api=3** in root directory.

## Services

### Web (Angular)

* Url: <https://localhost:8070>

### Gateway

* Api (Ocelot): <https://localhost:8080>

* Customer Api: <https://localhost:8080/customers>

* Product Api: <https://localhost:8080/products>

### Service Discovery (Consul)

* Url: <http://localhost:8500>

### Auth

* Api (Identity Server): <https://localhost:8075>

* Database (SQL Server)

**Migrations**

Add-Migration Identity_Initial -c IdentityDbContext -o Migrations/Identity

Add-Migration Configuration_Initial -c ConfigurationDbContext -o Migrations/Configuration

Add-Migration PersistedGrant_Initial -c PersistedGrantDbContext -o Migrations/PersistedGrant

### Customer

* Api (ASP.NET Core)

* Database (SQL Server)

**Migrations**

Add-Migration Initial

### Product

* Api (ASP.NET Core)

* Database (SQL Server)

**Migrations**

Add-Migration Initial

## Certificate

dotnet dev-certs https -ep localhost.pfx -p 123456

dotnet dev-certs https --trust

openssl pkcs12 -in localhost.pfx -out localhost.pem -nodes

openssl pkcs12 -in localhost.pfx -clcerts -nokeys -out localhost.crt

openssl pkcs12 -in localhost.pfx -nocerts -out localhost.key

## Todo

* Envoy

* Certbot
