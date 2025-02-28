import math
import re
pattern = "[0-9]*([+|\\-|*|/|sqrt|^][0-9]+)+"

class Calculator:
    def __init__(self):
        self.current_val = 0
        self.inp = ""
        self.ops = []
        print("Calculator initilized \nPlease uses spaces between operands and operations [+,-,*,/,^,sqrt]\nThe Calculator does not follow PEMDAS and using squareroot will wipe and previous value")
        self.running = True
            
        
    def doOperation(self,operator,operand):
        if operand.isnumeric():
            operand = float(operand)    
        if operator == "+":
            return self.current_val + operand
        elif operator == "-":
            return self.current_val - operand
        elif operator == "*":
            return self.current_val * operand
        elif operator == "/":
            if operand == 0:
                raise Exception("Can not divide by zero")
            return self.current_val / operand
        elif operator == "^":
            return self.current_val**operand
        elif operator == "sqrt":
            return math.sqrt(operand)
            
    def checkInput(self,inp):
        return re.fullmatch(pattern ,inp.replace(" ",""))
           
    def waitForInput(self):
        print(self.current_val)
        self.inp = input()
        if not self.checkInput(self.inp):
            print("Invalid input")
            return

        if self.inp == "q" or self.inp == "quit":
            self.running = False 
            return
        self.ops = self.inp.split(" ")
        if self.ops[0].isnumeric():
            length = len(self.ops)
            index = 1
            self.current_val= float(self.ops[0])
               
            while index < length:
                self.current_val = self.doOperation(self.ops[index],self.ops[index+1])
                index += 2
        else:
            length = len(self.ops)
            index = 0               
            while index < length:
                self.current_val = self.doOperation(self.ops[index],self.ops[index+1])
                index += 2


    def startCalculator(self):
        while self.running:
            self.waitForInput()
        print("Closing calculator")

        
    
def main():
    Cal = Calculator()
    Cal.startCalculator()

    

if __name__ =="__main__":
    main()