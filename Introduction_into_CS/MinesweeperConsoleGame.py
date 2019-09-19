import string
import random
import time
import pickle


#create grid
def create_grid(size,lastcell,numberofmines):
    grid = []
    for i in range(size):
        row = ['0']*size
        grid.append(row)
    mines = create_mines(grid,lastcell,numberofmines,size)
    p = surrounding(grid,size)
    p.numberofsurrounding(grid,size)
    return (grid,mines)


#show the grid 
def showgrid(grid,size):
    horizontal = ' -'+size*'----'
    collum = '   '
    #writes the collmum numbers
    for i in string.ascii_uppercase[:size]:
        collum += (i+ '   ')
    print (collum,'\n',horizontal)
    # writes row numbers
    for idx,i in enumerate(grid, start=1):
        row = str(idx)
        row += '|'
        for j in i:
            row = row+' '+j+' |'
        print (row+'\n'+horizontal)


#generated random cordinates 
def generate_cordinate(size):
    a = random.randint(0,size-1)
    b = random.randint(0,size-1)
    return (a,b)


#class fro surrounding
class surrounding(object):
    def __init__(self,grid,size):
        self.grid = grid
        self.size = size


    #creates a list with the surrounding cell for every cell
    def surrounding_cells(self,row_num,col_num,size):
        surronding = []
        for i in range(-1,2):
            for j in range(-1,2):
                if i == 0 and j == 0:
                    continue
                elif -1<row_num+i<size and -1<col_num+j<size:
                    surronding.append((row_num+i,col_num+j))
        return (surronding)


    #checks how many  mines in the surronding cells
    def numberofsurrounding(self,grid,size):
        for row_num,row in enumerate(grid):
            for col_num,col in enumerate(row):
                if col!='*':
                    #finds value of surrounding cell
                    values = [grid[r][c] for r,c in self.surrounding_cells(row_num, col_num,size)]
                    # counts how many are mines
                    grid[row_num][col_num] = str(values.count('*'))


#mines
def create_mines(grid,lastcell,numberofmines,size):
    mines = []
    for i in range(numberofmines):
        cell = generate_cordinate(size)
        while cell==(lastcell[0],lastcell[1]) or cell in mines:
            cell = generate_cordinate(size)
        mines.append(cell)
    for i,j in mines: grid[i][j] = '*'
    return mines


#choose cell
def showcell(grid,showngrid,row_num,col_num,size):
    #if you pick already shown cell
    if showngrid[row_num][col_num]!='-':
        return
    #shows the cell
    showngrid[row_num][col_num] = grid[row_num][col_num]
    #if the cells value is 0 controll nearby cells
    if grid[row_num][col_num] == '0':
        p = surrounding(grid,size)
        for r,c in p.surrounding_cells(row_num,col_num,size):
            showcell(grid,showngrid,r,c,size)


# replay
def replay():
    val = input('Do you want to go to the main menu?(yes/no):')
    if val.lower() == 'yes':
        mainmenu('Main menu')
    elif val.lower() == 'no':
        print('Goodbye! :)')
        quit()
    else:
        print('\n Please type yes or no only')
        replay()


#function for flags
def putflag(showngrid,row_num,col_num,flags):
    # adds flag
    if showngrid[row_num][col_num]=='-':
        showngrid[row_num][col_num] = 'F'
        flags.append((row_num,col_num))
    #remove flag
    elif showngrid[row_num][col_num]=='F':
        showngrid[row_num][col_num] = '-'
        flags.remove((row_num,col_num))


#function to pick number of mines 
def pickvalues():
    size = goodvalues(4,10,message= '\nPick size of grid(4-9):')
    numberofmines = goodvalues(size, ((size**2) -5), message= 'the number of mines has to be between ' + str(size) + ' and '+ str((size**2-6))+ '\nhow many mines:' )
    return size,numberofmines


#checks values, (size/numberofmines)
def goodvalues(min,max,message):
    a = False
    while a == False:
        try:
            värde = int(input(message))
            if värde not in range(min,max):
                a = False
            if värde in range(min,max):
                a = True
        except ValueError:
            print("\nchoose an interger\n")
            a = False
    return (värde)

def name(message):
    username = input(message)
    if len(username) <= 0 or len(username) >10:
        name('Pick a username:')
    return username


#main programm
def play():
    username = name('Choose a username(1-10 signs):')
    size,numberofmines = pickvalues()
    start_time = time.time()
    showngrid = [['-' for i in range(size)] for i in range(size)]        
    showgrid(showngrid,size)
    first_round = True
    flags = []
    while True:
        while True:
            flag = False
            lastcell = input('pick cell: ')
            try:
                if lastcell[2].lower() == 'f':
                    flag = True
            except IndexError:
                pass
            try:
                
                lastcell = (int(lastcell[1])-1,string.ascii_lowercase.index(lastcell[0].lower()))
                break
            except (IndexError,ValueError):
                showgrid(showngrid,size)
                print ("cant choose that cell")

        if first_round == True:
            first_round = False
            grid,mines = create_grid(size,lastcell,numberofmines)

        row_num = lastcell[0]
        col_num = lastcell[1]

        if flag == True:
            putflag(showngrid,row_num,col_num,flags)

        else:
            try:
                if grid[row_num][col_num] == '*':
                    result('Game Over',grid,showngrid,start_time,numberofmines,size,username)

                else:
                    showcell(grid,showngrid,row_num,col_num,size)
            except IndexError:
                print("\nCan't choose that cell\n")

        #for victory
        controll(grid,showngrid,size,numberofmines,start_time,username,flags,mines)

        showgrid(showngrid,size)

#function to check victory
def controll(grid,showngrid,size,numberofmines,start_time,username,flags,mines):
    empty_cells = 0
    cellswithmines = 0
    for x in range(len(showngrid)):
        y = (showngrid[x].count('-'))
        empty_cells += y
    for x in range(len(grid)):
        z = (grid[x].count('*'))
        cellswithmines += z
    if empty_cells == cellswithmines or set(flags) == set(mines):
        result('YOU WON',grid,showngrid,start_time,numberofmines,size,username)


#results reuslt (lose/win)
def result(result,grid,showngrid,start_time,numberofmines,size,username):
    if result == 'Defeat':
        print('Game Over!')
        showgrid(grid,size)
        replay()
    if result == 'Victory':
        print('*********** CONGRATULATIONS YOU WON!! ************')
        showgrid(showngrid,size)

        score(start_time,numberofmines,size,username)


# calculates score
def score(start_time,numberofmines,size,username):
    finish_time = time.time()
    time = start_time - finish_time
    user_score = (int((1000 * ((int(numberofmines))**2 / (int(size))) - (1.5 * time))), username)
    highscore(user_score)


#Opens highscore and adds you on the list 

def highscore(user_score):
    with open ('high_scorelist.dat','rb') as file:
         high_scorelist = pickle.load(file)
    if user_score[0] > high_scorelist[len(high_scorelist)-1][0]:
        print ("YOU MADE IT!\n\n")
        high_scorelist.append(user_score)
        high_scorelist.sort(reverse=True)
        del high_scorelist[len(high_scorelist)-1]
        with open('high_scorelist.dat','wb') as file:
            pickle.dump(high_scorelist,file)
        show_highscore(high_scorelist)
        return (high_scorelist)
    else:
       show_highscore(high_scorelist)


#prints the highscore table
def show_highscore(high_scorelist):
    print('****highscore***\n\n')
    print('|        name        |    score    |')
    for i in range(10):
        print('| ',high_scorelist[i][1],' '*(17-len(high_scorelist[i][1])), end='|')
        print(high_scorelist[i][0], ' ' *(12- len(str(high_scorelist[i][0]))), end= '|\n')
    replay()


#mainmenu
def mainmenu(message):
    print(message)
    a = str(input('1.Play\n2.Highscore\n3.Quit\n'))
    
    if a =='1':
        play()
    elif a =='2':
        highscore(user_score=(0,'test'))
    elif a == '3':
        print('Goodbye :(!')
        quit()
    else:
        mainmenu(message='Please choose between 1-4')

'''
#helpmenu
def help():
    print('what can I help you with?')
    while True:
        try:
            x = int(input('1. bla\n2. blar\n3. bla\n4. play'))
            if x == 1:
                a = input(('bla '))
            elif x == 2:
                a = input(('bla'))
            elif x == 3:
                a = input('bla')
            elif x == 4:
                mainmenu(message='here we go')
        except ValueError:
            print('\nchoose\n')
'''

#opens mainmenu
mainmenu(message='MineSweeper!')
