import tkinter as tk

morse_code_dict = {
    'A': ".-", 'B': "-...", 'C': "-.-.", 'D': "-..", 'E': ".", 
    'F': "..-.", 'G': "--.", 'H': "....", 'I': "..", 'J': ".---", 
    'K': "-.-", 'L': ".-..", 'M': "--", 'N': "-.", 'O': "---", 
    'P': ".--.", 'Q': "--.-", 'R': ".-.", 'S': "...", 'T': "-", 
    'U': "..-", 'V': "...-", 'W': ".--", 'X': "-..-", 'Y': "-.--", 
    'Z': "--..", '0': "-----", '1': ".----", '2': "..---", '3': "...--", 
    '4': "....-", '5': ".....", '6': "-....", '7': "--...", '8': "---..", 
    '9': "----.", ' ': "/"
}

inverse_morse_code_dict = {v: k for k, v in morse_code_dict.items()}

def to_morse():
    english_text = english_input.get().upper()
    morse_output.set(to_morse_code(english_text))
    
def to_english():
    morse_text = morse_input.get()
    english_output.set(to_english_text(morse_text))

def to_morse_code(text):
    ret = ""
    for char in text.upper():
        if char in morse_code_dict:
            ret += morse_code_dict[char] + " "
    return ret.strip()

def to_english_text(text):
    words = text.split(" / ")
    ret = ""
    for word in words:
        chars = word.split(" ")
        for char in chars:
            if char in inverse_morse_code_dict:
                ret += inverse_morse_code_dict[char]
        ret += " "
    return ret.strip()

root = tk.Tk()
root.title("Morse Code Translator")

english_input = tk.StringVar()
morse_input = tk.StringVar()
english_output = tk.StringVar()
morse_output = tk.StringVar()

tk.Label(root, text="English:").grid(row=0, column=0)
tk.Entry(root, textvariable=english_input).grid(row=0, column=1)
tk.Label(root, text="Morse:").grid(row=1, column=0)
tk.Entry(root, textvariable=morse_input).grid(row=1, column=1)

tk.Button(root, text="To Morse", command=to_morse).grid(row=2, column=0)
tk.Button(root, text="To English", command=to_english).grid(row=2, column=1)

tk.Label(root, text="Morse Code Output:").grid(row=3, column=0)
tk.Entry(root, textvariable=morse_output).grid(row=3, column=1)
tk.Label(root, text="English Output:").grid(row=4, column=0)
tk.Entry(root, textvariable=english_output).grid(row=4, column=1)

root.mainloop()