# Shopify Backend Challenge

Greetings,

My name is Deep Patel and this is the repository for my submission for the Shopify backend developer intern for summer 2022 challenge.

I originally envisoned of creating a basic front end using React however due to time constraints and issues with creating a ASP.NET framework with React project, I was unable to properly finish the front end. Therefore, the current version of the repository contains finished backend endpoints and unfinished frontend.

This project was created using C# and SQLite database using ASP.NET framework for the back-end. It contains CRUD features as well as allowing specific inventory to be added or removed from a collection. The project contains industry standard code which features error detection, input validation, and specific error codes to provide further information on which type of error has occured. Although the front-end does not currently work, it was implemented using React to allow a basic user interface to navigate to different pages for specific functions.

## Table of Contents
- [Installation](#installation)
- [Endpoints Tutorial](#endpoints)
  - [Add Inventory](#add-inventory)
  - [View all Inventories](#view-all-inventories)
  - [View a specific Inventory](#view-specific-inventory)
  - [Update Inventory](#update-inventory)
  - [Delete Inventory](#delete-inventory)
  - [Add Inventory to Collection](#add-inventory-to-collection)
  - [View Collection Inventories](#view-collection-inventories)
  - [Remove Inventory from Collection](#remove-inventory-from-collection)
- [Closing Remarks and Next Steps](#closing-remarks-and-next-steps)

# Installation
- The preferred IDE of choice is Visual Studio Code - https://code.visualstudio.com/download
- Extensions needed within Visual Studio Code:
  - "C#" By Microsoft
  - "SQLite" By alexcvzz  
- .NET SDK (Version 5.0) - https://dotnet.microsoft.com/en-us/download/dotnet/5.0
- Postman for testing API calls - https://www.postman.com/
- Clone repository - https://github.com/DeeepPatel/Deep_Patel_Backend_Challenge.git
  - Upon opening repository on Visual Studio Code, please be aware of a pop-up bottom right mentioning installing required assets to build and debug. Please select "Yes"
- To open the database in Visual Studio Code
  - Press "crtl + shift + p" on windows or "cmd + shift + p" on macOS and select "SQLite: Open Database" and then "InventoryDatabase.db"
  - This will open a section within the explorer called "SQLITE EXPLORER" which will allow the user to view the database contents
- To run the project: Open a terminal and navigate to the project file and enter the command "dotnet run"



# Endpoints Tutorial
All the endpoints will be tested using this URL:
 - http://localhost:5000/api/home/

## Add Inventory
URL: http://localhost:5000/api/home/
 - Method: POST

- If using postman, enter the URL and navigate to "Body" then select "raw" and lastly switch to JSON as shown below
![JSON_setup](https://user-images.githubusercontent.com/55398707/150236000-d5c3ffc2-53b8-4ace-8d60-d6a47857d2a1.png)

Enter in the body and click "Send":
```json
{
    "Name": "IPhone 13 Pro Max",
    "Description": "A mobile phone from the company Apple",
    "Amount": 1    
}
```
![AddInventory_1](https://user-images.githubusercontent.com/55398707/150236156-076dfbe1-97a3-4b05-a181-9b27d6257bbb.png)

After clicking "Send" there will be a response saying "(inventory_name) inventory added to the database." As shown below
![AddInventory_2](https://user-images.githubusercontent.com/55398707/150236423-5a345c3e-80a7-4aac-8a57-c6ad58546877.png)


## View all Inventories
URL: http://localhost:5000/api/home/inventories
 - Method: GET
Enter the URL and after clicking "Send" the output will be similar to this example:
![GetAllInventories](https://user-images.githubusercontent.com/55398707/150236790-b035fa2e-612a-4e7e-907a-33c9e901bab2.png)


## View a specific Inventory
URL: http://localhost:5000/api/home/{id}
 - Method: GET
 - Example URL used: http://localhost:5000/api/home/C3CB2BE4-62F3-4952-836F-8D89D8942705

Output:
![Get_Inventory_By_ID](https://user-images.githubusercontent.com/55398707/150236939-00c81e23-830f-4142-ba3c-4f3a50f43c5c.png)


## Update Inventory
URL: http://localhost:5000/api/home/update/inventory/{id}
 - Method: PUT
 - Example URL: http://localhost:5000/api/home/update/inventory/70FDFC15-C65F-4C80-B185-1C50020C2F08

Enter in the body and click "Send":
```json
{
    "Name": "IPhone 11 Mini",
    "Description": "A mobile phone from the company Apple",
    "Amount": 8    
}
```
Output:
![UpdateInventory](https://user-images.githubusercontent.com/55398707/150237341-48cd2e02-2c0d-4eac-8b87-a37210bbe84d.png)


## Delete Inventory
URL: http://localhost:5000/api/home/{id}
 - Method: DELETE
 - Example URL: http://localhost:5000/api/home/70FDFC15-C65F-4C80-1C50020C2F08

Output:
![Delete_Inventory](https://user-images.githubusercontent.com/55398707/150237623-6aa323dd-57b1-4153-8511-2418053e980e.png)


## Add Inventory to Collection
URL: http://localhost:5000/api/home/{id}
 - Method: POST
 - Example URL: http://localhost:5000/api/home/C3CB2BE4-62F3-4952-836F-8D89D8942705

Output:
![Add_Inventory_to_Favourite](https://user-images.githubusercontent.com/55398707/150238062-41ad8ea4-83a0-45e6-8399-d5f53783ac86.png)


## View Collection Inventories
URL: http://localhost:5000/api/home/favouritecollection
 - Method: GET

Output:
![Get_All_Favourites](https://user-images.githubusercontent.com/55398707/150238264-af4e5b8e-7782-4f45-a91b-d2517a0a78fe.png)


## Remove Inventory from Collection
RL: http://localhost:5000/api/home/favourites/{id}
 - Method: DELETE
 - Example URL: http://localhost:5000/api/home/favourites/EDC5D7ED-DC8A-4AEA-AFA0-A3070CEF872C

Output:
![Removed_from_Favourites](https://user-images.githubusercontent.com/55398707/150238373-8f0e636b-846b-4cfa-9457-cbf9d6ddafa8.png)

# Closing Remarks and Next Steps

While it is unfortunate that I was not able to implement a proper frontend for this project, I had a lot of enjoyment creating this backend challenge and was very excited to submit an application for the position. My next steps are to move this entire project into a new repository where I will separate the frontend and backend to proper files and aim to implement a functioning user interface for the project to avoid the current issues with having both within a single project. I will consistently update the project in the future so that I can continue developing my skills within these frameworks as well as attempt to recreate similar projects using other frameworks such as Ruby on Rails.

