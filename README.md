# Northwind C# Project

A project to help me learn and gain experience with various C#/.NET technologies.

- Create a C# API to retrieve data from the database
  - Using LINQ to query
  - Using Lambdas (what for, though?)
- Create a Blazor/MAUI application/website to display that data
- Create unit tests using xUnit for the API (and possibly any methods in my MAUI app)

## Installing prerequisites

You can install an MSSQL version of Northwind [here](https://github.com/Microsoft/sql-server-samples/tree/master/samples/databases/northwind-pubs). (The database is a little inconsistent in its use of data types for IDs, so beware.)

You will also need to install Entity Framework.

## Bugs

The `/Order` endpoint doesn't work for reasons I haven't fully ascertained. There's something wrong with the foreign key of `Shipper` in that table.

We're getting a `SQLException` and the program is complaining that there is no column called `ShipperID` in the table, but there demonstrably is. The stack trace is unhelpful: I can't see what SQL command the program is trying to execute under the hood and don't know where to look next.
