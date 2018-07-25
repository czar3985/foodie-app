# Foodie App

The Foodie App keeps a database of Restaurants and Menu Items for each restaurant.

## About the project

Based on the Restaurants python project that can be found in:
[restaurants](https://github.com/czar3985/restaurants). This is the version made
using ASP.NET MVC framework, C# and Entity Framework.

## Usage

Run in Microsoft Visual Studio

## Database Structure

```
Table Name: restaurant
Columns:
{'primary_key': 0, 'nullable': False, 'default': None, 'autoincrement': 'auto', 'type': VARCHAR(length=250), 'name': u'name'}
{'primary_key': 1, 'nullable': False, 'default': None, 'autoincrement': 'auto', 'type': INTEGER(), 'name': u'id'}

Table Name: menu_item
Columns:
{'primary_key': 0, 'nullable': False, 'default': None, 'autoincrement': 'auto', 'type': VARCHAR(length=80), 'name': u'name'}
{'primary_key': 1, 'nullable': False, 'default': None, 'autoincrement': 'auto', 'type': INTEGER(), 'name': u'id'}
{'primary_key': 0, 'nullable': True, 'default': None, 'autoincrement': 'auto', 'type': VARCHAR(length=250), 'name': u'description'}
{'primary_key': 0, 'nullable': True, 'default': None, 'autoincrement': 'auto', 'type': VARCHAR(length=8), 'name': u'price'}
{'primary_key': 0, 'nullable': True, 'default': None, 'autoincrement': 'auto', 'type': VARCHAR(length=250), 'name': u'course'}
{'primary_key': 0, 'nullable': True, 'default': None, 'autoincrement': 'auto', 'type': INTEGER(), 'name': u'restaurant_id'}
```

## Features

- View restaurant entries in the database
- Add a new restaurant entry
- Edit restaurant names
- Delete restaurants

## To Dos

_**Coding ongoing on all features**_