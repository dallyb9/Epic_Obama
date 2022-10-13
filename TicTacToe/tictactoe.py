from operator import index

move_count = 0
tie = 0
win = 0
player = 'x'
board = [1,2,3,4,5,6,7,8,9]
recorded_play = []

def print_board(board):
   
    print(f"\n{board[0]}|{board[1]}|{board[2]}")
    print('-+-+-')
    print(f"{board[3]}|{board[4]}|{board[5]}")
    print('-+-+-')
    print(f"{board[6]}|{board[7]}|{board[8]}\n")

def move(player, board, recorded_play):
    try:
        player_move = int(input(f"{player}'s turn: "))
        for i in player_move:
            if i == recorded_play[i]:
                print('That spot has been taken already')
    except: 
        pass
    board[player_move-1] = player 
    recorded_play.append(player_move-1)
    
def switch_player(player):
    if player == 'x':
        player = 'o'
    else: 
        if player == 'o':
            player = 'x'
    return player

def check_win(board, player):
    if (board[0] == 'x' and board[1] == 'x' and board[2] == 'x') or (board[3] == 'x' and board[4] == 'x' and board[5] == 'x') or (board[6] == 'x' and board[7] == 'x' and board[8] == 'x') or (board[0] == 'x' and board[3] == 'x' and board[6] == 'x') or (board[1] == 'x' and board[4] == 'x' and board[7] == 'x') or (board[2] == 'x' and board[5] == 'x' and board[8] == 'x') or (board[0] == 'x' and board[4] == 'x' and board[8] == 'x') or (board[2] == 'x' and board[4] == 'x' and board[6] == 'x'):
        print(f"x wins!")
        win = 1
        print_board(board)
        return win
    if (board[0] == 'o' and board[1] == 'o' and board[2] == 'o') or (board[3] == 'o' and board[4] == 'o' and board[5] == 'o') or (board[6] == 'o' and board[7] == 'o' and board[8] == 'o') or (board[0] == 'o' and board[3] == 'o' and board[6] == 'o') or (board[1] == 'o' and board[4] == 'o' and board[7] == 'o') or (board[2] == 'o' and board[5] == 'o' and board[8] == 'o') or (board[0] == 'o' and board[4] == 'o' and board[8] == 'o') or (board[2] == 'o' and board[4] == 'o' and board[6] == 'o'):
        print(f"o wins!")
        win = 1
        print_board(board)
        return win
    else:
        win = 0
    return win

def check_tie(move_count):
    if move_count == 9:
        tie = 1
        print('TIE!')
        return tie
    else: 
        pass


def main(player, board, move_count, tie, win, recorded_play):
    while (move_count <= 8) and (tie == 0) and (win == 0):
        move_count += 1
        print_board(board)
        move(player, board, recorded_play)
        player = switch_player(player)
        # tie = check_tie(board)
        win = check_win(board, player)
        if move_count == 9:
            print('Tie')
        


main(player, board, move_count, tie, win, recorded_play)



