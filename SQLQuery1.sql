create database VehiclesDB
go
use VehiclesDB
go
create table vendors (vendorId int identity(1,1) primary key not null, businessName varchar(50), firstName varchar(50), lastName varchar(50), gender varchar(10), phone varchar(50),
address varchar(50), city varchar(50))

create table customers (customerId int identity(1,1) primary key not null, firstName varchar(50), lastName varchar(50), gender varchar(10), phone varchar(50),
address varchar(50), city varchar(50))

create table vehicleMakes (makeId int identity(1,1) primary key not null, makeDesc varchar(50))

create table vehicleModels (modelId int identity(1,1) primary key not null, makeId int foreign key references vehicleMakes (makeId), modelDesc varchar(50))

create table vehicles (vehicleId int identity(1,1) primary key not null, modelId int foreign key references vehicleModels (modelId), vendorId int foreign key
references vendors (vendorId), color varchar(50), picture varbinary(max), vin varchar(50))

create table features (featureId int identity(1,1) primary key not null,featureDesc varchar (50))

create table vehicleFeatures (vehicleFeaturesId int identity(1,1) primary key not null, featureId int foreign key 
references features (featureId), vehicleId int foreign key references vehicles (vehicleId))