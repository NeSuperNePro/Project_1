import pygame
import random

pygame.init()
from tkinter import *


def game():
    root.wm_attributes('-alpha', 0.0)
    SIZE_BLOCK = 20
    FRAME_COLOR = (30, 144, 255)
    WHITE = (255, 255, 255)
    BLUE = (204, 255, 255)
    RED = (224, 0, 0)
    HEADER_COLOR = (0, 83, 138)
    SNAKE_COLOR = (0, 102, 0)
    COUNT_BLOCKS = 20
    HEADER_MARGIN = 100
    MARGIN = 1

    size = [SIZE_BLOCK * COUNT_BLOCKS + 2 * SIZE_BLOCK + MARGIN * COUNT_BLOCKS,
            SIZE_BLOCK * COUNT_BLOCKS + 2 * SIZE_BLOCK + MARGIN * COUNT_BLOCKS + HEADER_MARGIN]
    print(size)
    screen = pygame.display.set_mode(size)
    pygame.display.set_caption(programName)
    timer = pygame.time.Clock()
    Arial = pygame.font.SysFont('Arial', 36)

    class SnakeBlock:
        def __init__(self, x, y):
            self.x = x
            self.y = y

        def is_inside(self):
            return 0 <= self.x < COUNT_BLOCKS and 0 <= self.y < COUNT_BLOCKS

        def __eq__(self, other):
            return isinstance(other, SnakeBlock) and self.x == other.x and self.y == other.y

    def get_random_empty_block():
        x = random.randint(0, COUNT_BLOCKS - 1)
        y = random.randint(0, COUNT_BLOCKS - 1)
        empty_block = SnakeBlock(x, y)
        while empty_block in snake_block:
            empty_block.x = random.randint(0, COUNT_BLOCKS - 1)
            empty_block.y = random.randint(0, COUNT_BLOCKS - 1)
        return empty_block

    def draw_block(color, row, column):
        pygame.draw.rect(screen, color, [SIZE_BLOCK + column * SIZE_BLOCK + MARGIN * (column + 1),
                                         HEADER_MARGIN + SIZE_BLOCK + row * SIZE_BLOCK + MARGIN * (row + 1),
                                         SIZE_BLOCK,
                                         SIZE_BLOCK])

    snake_block = [SnakeBlock(9, 8), SnakeBlock(9, 9), SnakeBlock(9, 10)]
    apple = get_random_empty_block()
    d_row = buf_row = 0
    d_col = buf_col = 1
    total = 0
    speed = 1

    while True:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                print('выход')
                pygame.quit()
                sys.exit()
            elif event.type == pygame.KEYDOWN:
                if event.key == pygame.K_UP and d_col != 0:
                    buf_row = -1
                    buf_col = 0
                elif event.key == pygame.K_DOWN and d_col != 0:
                    buf_row = 1
                    buf_col = 0
                elif event.key == pygame.K_LEFT and d_row != 0:
                    buf_row = 0
                    buf_col = -1
                elif event.key == pygame.K_RIGHT and d_row != 0:
                    buf_row = 0
                    buf_col = 1

        screen.fill(FRAME_COLOR)
        pygame.draw.rect(screen, HEADER_COLOR, [0, 0, size[0], HEADER_MARGIN])

        text_total = Arial.render(f"Total: {total}", bool(0), WHITE)
        text_speed = Arial.render(f"Speed: {speed}", bool(0), WHITE)
        screen.blit(text_total, (SIZE_BLOCK, SIZE_BLOCK))
        screen.blit(text_speed, (SIZE_BLOCK + 200, SIZE_BLOCK))

        for row in range(COUNT_BLOCKS):
            for column in range(COUNT_BLOCKS):
                if (row + column) % 2 == 0:
                    color = BLUE
                else:
                    color = WHITE

                draw_block(color, row, column)

        head = snake_block[-1]
        if not head.is_inside():
            print('выход за пределы поля')
            root.wm_attributes('-alpha', 1.0)
            pygame.display.quit()
            break

        draw_block(RED, apple.x, apple.y)
        for block in snake_block:
            draw_block(SNAKE_COLOR, block.x, block.y)

        if apple == head:
            total += 1
            if total % 5 == 0:
                speed += 1
            snake_block.append(apple)
            apple = get_random_empty_block()

        d_row = buf_row
        d_col = buf_col
        new_head = SnakeBlock(head.x + d_row, head.y + d_col)

        if new_head in snake_block:
            print('врезался в себя')
            root.wm_attributes('-alpha', 1.0)
            pygame.display.quit()
            break

        snake_block.append(new_head)
        snake_block.pop(0)

        pygame.display.flip()
        timer.tick(3 + speed)


def exit():
    pygame.quit()
    sys.exit()


root = Tk()

programName = "Zмея ебучая"
root.title(programName)

root.wm_attributes('-alpha', 1.0)

w = root.winfo_screenwidth()
h = root.winfo_screenheight()
w = w // 2
h = h // 2
w = w - 200
h = h - 200

root.geometry('400x500+{}+{}'.format(w, h))
root["bg"] = "#00538A"

root.resizable(width=False, height=False)

root.update()
x_window = root.winfo_width() / 2
y_window = root.winfo_height() / 2

otstup = 20

btn_game = Button(root, text="Играть", font=("Arial", 50), bg="#1E90FF", fg="#FFFFFF", command=game)
centerx_btn_game = x_window - (btn_game.winfo_reqwidth() / 2)
centery_btn_game = y_window - (btn_game.winfo_reqheight() / 2)
btn_game.place(x=centerx_btn_game, y=centery_btn_game - (btn_game.winfo_reqheight() / 2) - (otstup / 2))

btn_exit = Button(root, text="Выход", font=("Arial", 50), bg="#1E90FF", fg="#FFFFFF", command=exit)
centerx_btn_exit = x_window - (btn_exit.winfo_reqwidth() / 2)
centery_btn_exit = y_window - (btn_exit.winfo_reqheight() / 2)
btn_exit.place(x=centerx_btn_exit, y=centery_btn_exit + (btn_exit.winfo_reqheight() / 2) + (otstup / 2))

root.mainloop()
