Feb-18-22
8:05am - 9:00: Work in Figma to brainstorm how users might want to query the API so I can figure out what key words and info to include in my API


9:00 - 10:00: Research if possible to send over more than one ingredient at a time to swap for an API query

10:15 - 11:00: Create Google Sheet to start entering data and plant subs for my API. Still contemplating best way to organize the queries. Also, researching Walmart in various mid-West/non-Portland cities to understand what kind of products are available in other parts of the country. Portland has a lot to offer vegans, I want to offer everyone the ability to find subs. 

11:15 - 11:30: Back to Figma to rework UX choices

1:15 - 2:30 Work in GoogleSheets to populate API

2:30 - 3:30 Start Udemy course on React.

Feb-20-22 

8:15pm - Talked over my project with a friend last night, while talking through what I planned to do with her I finally figured out how to structure my swaps. Working now in GoogleSheets to restructure my API.

9:10pm- Restructured and added swaps to API.

Feb-24-22

8:30 - 9:00 Added columns to google sheets before getting ready to import csv into mySqul. Sheets need a lot of work (entries) but I finally have a good structure to follow. Will import sheet today to create table but will end up filling in many, many more swaps and re-importing the csv again.

10:45 - 11:30 Prep sheet before import and initial migration

11:30 - 1:00 lunch/walk

1:00 - 2:00 add a few test items to a sheet following swap model to import into API to call in Postman

2:30 - 4:45 debug imports, csv isn't importing correctly, migrations not working. API does connect to Postman but returns empty response.

8:45 - 9:15 got test google sheet to import in mysql and had successful call on Postman.

9:00 - 9:15 watch tutorial on react api queries on youtube

3-8-2022

9:30 - 10:00 edit and create content in google sheet to get API ready to upload to Azure

10:30 - 11:00 edit and create content in google sheet

<!-- 
const swapReveal = (results) => {
    for(i = 0;i<results.length;i++){
        if((results[i].ingredientToSwap === "chicken") && (results[i].cuisineType === "Thai")){
            return results[i];
        }
    }
} -->

