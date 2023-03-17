# OldPhoneKeypad
  This repository contains a sample of old phone keypad using windows forms application

  A windows form which is designed similar to old phone keypad is the User Interface in his application. The interface contains buttons to input numbers from 2 to 9, * and <space> and a textbox to display the input as well as final output strings.
  Each button has a number to identify it and pressing a button multiple times will cycle through the letters on it allowing each button to represent more than one letter.
  For example, pressing 2 once will return ‘A’ but pressing twice in succession will return ‘B’.
  A pause for a second is provided in order to type two characters from the same button after each other: “222 2 22” -> “CAB”.
  
Functions of various buttons are:
 -> Buttons from number 2 to 9 represents alphabets A to Z. 
 -> Button with number 1 function as a clear button which clears any text in the textbox 
 -> Button with number 0 adds space between characters
 -> Button with symbol * is a backspace button which deletes the last character from the input string
 -> Button with symbol # when clicked will find out letters corresponding to numbers and symbol in the input string
  
Working:
 -> Make sure the textbox is clear before clicking any button
 -> Click on the buttons to get desired string in the same way we use old phone keypad (at this time the textbox will show the numbers and symbol you type, not alphabets)
 -> A pause of 1 sec is added in order to type two characters from the same button(the pause is represented by a space in the input string. it will not be reflected in the final output)
 -> After entering the desired input, click on button '#' or 'send' to display the final output in the textbox
 -> Make sure to clear the current result using button 1 before starting with new input
  
