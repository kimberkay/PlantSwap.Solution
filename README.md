# Plant Swap API

#### By: Kim Brannian

#### _An API to provide plant-based swaps for animal-based ingredients._

## Technologies Used
* C#
* .NET5
* NuGet
* ASP.NET Core
* Swagger
* git
* GitHub
* MySQL
* MySQL Workbench
* Google Sheets
* Cors

## Description
_An api a user can query to find plant-based substitutions for plant based ingredients based on ingredient and cuisine type._

## Setup/Installation Instructions
* Download, install, and configure MySQL
* Open the terminal on your desktop
* Once in the terminal, use it to navigate to your desktop folder
* Once inside your desktop folder, use the command `git clone https://github.com/kimberkay/PlantSwap.Solution.git`
* After cloning the project, navigate into it using the command `cd PlantSwap.Solution/PlantSwap`
* Create a file named "appsettings.json" in the `PlantSwap` directory
* Add the following code to appsettings.json and add your MySQL user ID and password:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parks;uid=[YOUR MYSQL USER ID];pwd=[YOUR MYSQL PASSWORD];"
  }
}
```
* Then run the command `dotnet ef database update`
* After creating the database, you'll need to populate it with the data in the .csv file.
* Go to MySQL Workbench and navigate to the table `plant_swap`. Click on the arrow on the left to open the schema details. 
* Right click on `plant_swap` table and select "Table Data Import Wizard"
* Navigate to where you cloned the project and select the file `PlantSwaps.csv`
* Click next through the following windows to import the data
* If you need help, see this article: https://towardsdatascience.com/how-to-import-a-csv-file-into-mysql-workbench-17cb120169c8 
* After importing the data, return to your terminal
* Then run the command `dotnet restore` to install project dependencies
* Then run the command `dotnet run` to start the server

## API endpoints
#### HTTP Requests
```
GET /api/swaps
GET /api/swaps/{id}

```


#### Example Query
```
https://localhost:5001/api/swaps/1

```

#### Sample JSON
```
{
    "swapId": 1,
    "ingredientToSwap": "chicken",
    "cuisineType": "Italian",
    "swapOne": "store bought breaded chicken",
    "swapOneAbout": "You can find these products in the freezer section of most well stocked grocery store. They might be in a plant-based section (Target has this section now) or next to regular chicken nuggets. Boca chick'n patties are great left in pattie form or can be baked then sliced or diced up to add to your recipe. Gardein brand chicken tenders really ring the bell when a chicken tender or nugget is required. ",
    "swapOneFlavorNotes": "Boca patties sliced up work great in many Italian dishes",
    "swapOnePrep": "Follow package instructions for baking",
    "swapTwo": "Soy Curls",
    "swapTwoAbout": "Soy curls are a dehydrated soy product made by soaking the beans in fresh water and then constantly stirring them while they cook. Then they get dried at low temperatures which gives them a rich, chewy feel and ready to absorb any flavor you put to them.",
    "swapTwoFlavorNotes": "After they are rehydrated, saute soy curls in pan with onions and other spices so the outside can crisp and grab the flavors",
    "swapTwoPrep": "Boil enough water with a veggie boulian cube or pre-made veggie broth to cover soy dehydrated soy curls. Turn off heat and let curls soak up broth and come to size. After ten minutes, drain and follow recipe directions as you would for cooking up chicken.",
    "swapThree": "cannelini beans or other larger white bean",
    "swapThreeAbout": "White beans like cannelinis, limas and if you're lucky enough to find them, Christmas limas, will impart a nutty, ",
    "swapThreeFlavorNotes": "For a rich flavor, boil your beans up with a veggie broth or no chick'n broth and add a bit of garlic powder and nutritional yeast.",
    "swapThreePrep": "Open a can and drain and rinse them or buy them in bulk and cook them up in the instapot or stovestop before adding to your dishes. whatever flavor you lend them and add a delightful heartiness any pasta, rice or side dish."
    }
```

#### Swagger Instructions
This API uses [Swagger](https://swagger.io/tools/swagger-ui/) REST API Documentation

* Navigate to http://localhost:5000/index.html to access Swagger and view API endpoints
* Note: the server must be running to access Swagger and test out parameters

## Known Bugs
* There is a lot of content creation that still needs to happen. This is definitley just a prototype.

## License
_MIT License: https://opensource.org/licenses/MIT_

Copyright (c) _2022_ _Kim Brannian_

