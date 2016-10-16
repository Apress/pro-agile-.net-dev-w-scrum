Welcome to the KojackGames Blackjack application!  Here are a few pointers to get you started in running the application:

The KojackGames.Blackjack.UI.Web is the startup application for this solution.  Verify that it is selected as such.

There's a few requirements that are needed to run this application:

1.  SQLExpress is installed and the service is running
2.  KojackGames.Blackjack.UI.Web is the startup project

Running the Acceptance Tests:

Configuration:  
In order to run the Acceptance tests that use WatiN using IE8 you will have to do one of the following:

- Run Visual Studio in administrator mode or run the RunUATTests batch file in administrator mode.

- In Internet Explorer, open Tools -> Internet Options -> Security -> Local intranet and check the box "Enable Protected Mode."

Running the Acceptance Tests:
1.  Compile and run the application manually to verify that it loads. 
2.  Once the application loads, you can close it down
3.  Right click on the Kojack.Games.Blackjack.Acceptance.Tests and click "Run Tests" if you have TestDrive.Net installed.  The system will run the Acceptance Tests.