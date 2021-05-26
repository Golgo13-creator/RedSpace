# Embrace Space

This application enables the user to create, edit, view and delete space ships, space stations, and launch sites. In addition to these functions, each table in their 
respective view can be filtered by name or location depending on the table. 

  Also, an additional view named ShipOrigin allows the user to see space ships linked to their 
respective launch site. However, in order for this foreign key relationship to work, the launch site must be created first. The user must then get the Id of the launch 
site they want to use and apply that number as the LaunchSiteID when creating a space ship. The Id of the launch site can be viewed by clicking on the details link of 
the chosen launch site. 

  In order to create and/or view any of the tables, one must register using an email address and password. After successfully logging in, the tables
will appear in the nav bar. The home page also has build buttons that will take the user to the create page of the object that they select. However, if one is not yet 
logged in, they will be directed to a login/register page. 
