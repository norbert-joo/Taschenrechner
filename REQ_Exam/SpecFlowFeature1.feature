Feature: Taschenrechner
	Als Benutzer möchte ich einen Taschenrechner verwenden, 
	damit ich trigonometrische Funktionen berechnen kann.


@mytag
Scenario: Calculate Sinus
	Given the option is <sinus>
	And the parameter is 3.14
	When the calculate button is pressed
	Then the result should be 0

@mytag
Scenario: Calculate Cosinus
	Given the option is <cosinus>
	And the parameter is 3.14
	When the calculate button is pressed
	Then the result should be -1

@mytag
Scenario: Calculate Tangens
	Given the option is <tangens>
	And the parameter is 3.14
	When the calculate button is pressed
	Then the result should be 0