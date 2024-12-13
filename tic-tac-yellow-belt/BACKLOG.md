## User Stories

As a user I want a game board so that I can play the game on

As a user I want to have game pieces so that I can play the game

As a user I want someone to play against so that I can play the game

When I play the game I want it to be rounds so there is equal chances for be and the other player to winn

If I win the game I want to be notified that I won

If I lose the game I want to be notified that I lost

If the game is a tie I want to be notified that the game is a tie

As a user I don't want to have a other person the play against, so I want to play against a bot

## UAT

Given I am on the game board
When I click on a square
Then I should see my game piece in that square

Given I have two pieces in a row on the game bord
When I select a square that will give me three in a row
Then I should be notified that I won 

Given the other player has two pieces in a row on the game board
When they select a square that will give them three in a row
Then I should be notified that I lost

Given the game bord is full
And no player has tree pieces in a row
Then I should be notified that the game is a tie

Given I am playing against a bot
When I select a square
Then the bot should select a square

Given it is the bots turn
When the bot selects a square
Then I should see the bots game piece in that square

Given the bot selects a that´s already selected
When the bot selects a square
Then the bot should select a other square


