# Bees Challenge
Please see the word doc in the solution for the challenge

The challenge took longer than the stated 60 minutes as testing was included and a readme was added. I also don't like to rush things and took breaks during the development

## Assumptions
I've made the assumption that one button is used to damage all the bees, rather than a button per bee.

The UI has been kept minimal as it is not the focus of the challenge.

## Solution
For the logic, I've used a .NET Standard library as it's what I'm familiar with and it has the added benefit of being cross-platform if needed.

For this challenge there was no real need to create the IBee interface as everything could have been done on the BeeBase.cs. The interface would be used if the project ever got more complex and if there were different bee types, it can also be used for testing purposes.

For the UI, I've chosen a WPF application as it's my most familiar way to create UI's. It has the added benefit of making things like bindings very simple, especially when using the MVVM pattern.
The downside to this is that the BeeBase.cs has to implement INotifyProperty changed in order to be updated on the UI, which somewhat convolutes the class. This does not necessarily bind the Logic to the UI as INotifyProperty is not specific to WPF 

## Testing Approach 
I've chosen to use NUnit as it's my most familiar testing framework. Given the time frame of the challenge, it doesn't make sense to try and use a new framework, albeit I would like to use XUnit in the future

No strict naming convention has been followed for the tests as I feel not all tests follow the same pattern. 
Typically I tend to follow the Given_When_Then naming convention however for simpler tests it feels overkill and unnecessary.

I did not use TDD (Test-Driven-Development) for this project as the challenge was simple and there was a given time limit. For more complex project a TDD approach would be used.

## Future improvements
*   There is logic shared (the INotifyProperty related code) within the Logic project and UI project, this could be pulled out into a single class
*   The UI project could be tested, given the time frame of the challenge I felt this was not necessary
*   The UI could be improved, things like displaying the bee type would be nice