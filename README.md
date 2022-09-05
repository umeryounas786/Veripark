L1 - Penalty Calculation - Assignment - v2
In the assignment you are expected to develop the front-end using AngularJs or AngularApplication, and back-end using Asp.net MVC.
Requirements
1)	Develop a web page on which users will input
a.	Date the book is checked out.
b.	Date the book is returned.
c.	Country selection (at least 2 different countries)
d.	Calculate button
2)	The web page should display
a.	Calculated Business Days
b.	Calculated penalty
for the inputs.
3)	Penalty should be calculated for BUSINESS days only between the checkout and returned days of the book. The checkout and return dates are inclusive.
a.	It should consider weekends and national holidays/religious holidays defined in tables in database for a specific country.
b.	Note that some countries have different working days and weekends. For example in Dubai Friday and Saturday are off days. However in Turkey Saturday and Sunday are off days.
c.	Your code should not have these assumptions hardcoded but they must be in configurations. The configuration should be kept in a database table. 
d.	Do not provide a screen to edit these values in the database. Manual editing of these values is sufficient.
e.	You should develop your own algorithm for business day count. 
•	Hint: Try to use DayOfWeek enumeration of .Net for weekends.
4)	A book should be returned in 10 days. Any business day after 10 days will be considered as a late day.    
a.	Each late business day will be penalized for 5.00 $ (or currency code of country)
b.	The currency code and the amount is country specific. 
c.	Penalty amount should be a decimal value to accommodate for cents and fills and etc.
5)	Any monetary value you display on the screen should have proper formatting
Notes
•	Do not make OVERDESIGN.  The requirements are very simple and stated above. You will not receive extra points for making extra screens like login, user management, library management, book management etc. Please obey the requirements.  
•	We will grade your code by its quality. Try to use comments, exceptions, validations, and configuration parameters with readable code as much as possible. Avoid magic numbers and lengthy procedures in code.
•	Use Object Oriented Development concepts and develop your classes with proper constructors, methods, etc.
•	The application should be a web based application using a SQL server database for configuration.
Instructions
1)	You have two hours to complete this test. Maximum extension can be 60 minutes. Use 
2)	After completing we kindly request you to send us back the following:
a.	Screenhots showing that the calculation is correct. Please capture at least 4 possible test cases.
b.	Project files, including the source code
c.	Database backup
3)	Please archive all the above files in one .zip or .rar file and name it with your name
4)	Please ask any questions if you have any doubt about the requirements.
