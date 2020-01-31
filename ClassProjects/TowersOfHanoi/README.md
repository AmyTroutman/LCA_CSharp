#Code Plan

Board (named tower) will be a dictionary<string, stack(int)>. Tower A will have a stack of {1, 2, 3, 4}. Towers B and C will have empty stacks. 

##Get user input 
A do while loop:
string from = “Where do you want to move from?” 
string to = “Where do you want to move to?”
(both of the above with .ToUpper() to match my A B C)
Use tower[to].Push(tower[from].Pop()); to pop off the From tower and push onto the To Tower.  This is inside an if/else that checks if ValidMove method is true. If false, tells user they suck, and to try again. 

##CanDo(): 
A bool method
-Is from tower empty? (is there anything to move?)
-Is to tower empty? (if not then see next)
-Is pop bigger than to tower top piece? (use peek)
-Is from tower the same as to tower? (did you mean to do that?)

##WinCheck():
if (Tower C == 4) { bool win ==true; }
else { bool win == false; }
and then a PrintBoard() to show the updated positions.