# univeral-receiver.php
Server side web based Database Synchronizer for Desktop Applications.

## ToDo:
1. The script must serve to authorised connections only.
2. The uploaded files must stay outside of web access.

There is otherwise, a chance of sqlite query injection issue.

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

This is a work in progress, and the cocnept/idea is made public hoping that it helps you to push data to the websites.
The server php infrastructure source code will be pushed when it is tested.
Client side demo application can be written in many languages mostly like, python ([requests](https://docs.python-requests.org/en/latest/)), c# (Resthsarp), php (@anytizer/relay.php).

If you believe this application is useful to you and needs and advancement, please leave me a message.
