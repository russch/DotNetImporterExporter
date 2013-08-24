DotNetImporterExporter
======================

A tool that can be used to export objects from Tableau Server and publish them elsewhere. 

WARNING: Requires VS 2012 to edit and build. Tableau Software does NOT support this tool. If you are not familiar with .NET and Visual Studio, you will not be able to get this tool working and it frankly is not meant for you :)

Setup:

Task 1 - Enable remote access to the Tableau Server repository

Use steps 1-3 documented at http://onlinehelp.tableausoftware.com/current/server/en-us/help.htm#adminview_postgres_access.htm to enable remote connectivity to the Tableau Server repository database. This step is critical. If we can’t connect to the “workgroup” database, all bets are off. Remember the password you choose, as you’ll need it later.

Task 2 - Install the PostgreSQL 32-bit ODBC driver

If the “Server” and “Client” are the same machine, you can skip this step, as Tableau Server installs the ODBC driver automatically for you. If not, download and install the driver from postgresql.org. A direct link is here. 

Task 3 -  Create an ODBC System DSN

In order for TEC to communicate with the database which stores information about Tableau Server background processes, we need to create an ODBC DSN which points to the database in question. Follow these steps:

1.	If  the Client is a 32-bit machine, Click Start, then Run. Type odbcad32.exe in the Open text box and hit ENTER.

IMPORTANT: If your Client is a 64-bit box, type %SystemRoot%\syswow64\odbcad32.exe instead.

2.	In the ODBC Data Source Administrator, click the Drivers tab and scroll down to make sure thePostgreSQL Unicode driver appears in the Drivers list. If not, return to Task #2 and install it.
3.	Click the System DSN tab and click Add.
4.	In the list of drivers, choose PostgreSQL Unicode and click Finish.
5.	Configure the dialog:

Data Source: Workgroup
database: workgroup
Server: <your tableau server> host name
Username: tableau
Port 8060 (depends on your install)

Use the password you configured when using the tabadmin dbpass command way back in task #1. Replace my server name (SQLR2) with yours.
 
Make sure that Tableau Server is running, and click Test in the PostgreSQL Unicode ODBC Driver setup dialog. If the connection is not successful, you’ve got a problem. Make sure the stuff you typed in earlier  is correct.
Another (very!) common issue may be that port 8060 on the Server (the port that PostgreSQL talks to us on) is blocked by a firewall. You may need to open up port 8060 on the Server. Any number of tools could be blocking the port, but more often than not, it’s Windows Firewall. Read about opening up a port via Windows firewall here. 
6.	Jot down the name of your DSN (Data Source), then Save the setup and click OK to close the ODBC Administrator dialog.

Task 4 -  Edit TabImportExport.exe.config
Open TabImportExport.exe.config in notepad, and make sure the connectionString values for DSN, server, and port are pointing to the correct values for our PostgreSQL cluster.
