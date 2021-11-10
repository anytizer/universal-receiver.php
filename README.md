# univeral-receiver.php
Server side web based Database Synchronizer for Desktop Applications.

## How does it work?
Desktop application pushes its local schema and json to this recepient.
This software then recreates web database.

Thus, it is possible to expose desktop application based data into the website.

It synchronizes:
* Schema
* Data

Assuming, desktop application is a binary .exe or other gui based platforms as well as local web infrastructure, univeral receiver is a way to __clone__ the same data for the web.

### Server side script:
upload/receive.php

#### Accetable types:

    $types = ["database", "schema", "json"];

##### database:
Complete copy of an .sqlite database

##### schema:
A fully formed SQL DDL to create a table

##### json:
The data into json format
