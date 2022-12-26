#Returns a list with the ID of the sequence with the highest GC-content and its corresponding value(%)
def analyse_fasta(file_name):
    
    data = assimilate_data(file_name)
    highest_gc = gc_analysis(data)
    
    output = f"{highest_gc[0]} {highest_gc[1]}%"
    to_txt("gc_computation_result.txt", output)
    
    return highest_gc


#Iterate through FASTA file and returns a dictionary where key==ID and value==nucleotide sequence
#Takes in FASTA file name as argument
def assimilate_data(file_name):
    
    data = {}
    
    with open(file_name, 'r') as file:
        curr_id = ""
        curr_seq = ""
            
        for line in file:
            
            line = line.rstrip('\n')
            
            if line[0] == ">":
                curr_id = line[1::]
                curr_seq = ""
                data[curr_id] = "" 
                
            else:
                curr_seq += line
                data[curr_id] = curr_seq
    
    return data

    #Determines sequence with the highest GC Content (in form of a list)
#Takes in dictionary of nucleotide sequences with their respective IDs as argument
def gc_analysis(data):
    
    lst_max = ["id_placeholder", 0]
    
    for key, value in data.items():
        
        print(key)
        
        gc_content = calculate_gc(value)
        print(f"{gc_content}%\n")
        
        if gc_content > lst_max[1]:
            lst_max[0] = key
            lst_max[1] = gc_content
            
    return lst_max

#Calculates the GC content of a given nucleotide sequence (%)
#Takes in nucleotide sequence (as str) as argument
def calculate_gc(seq):
    
    seq_len = len(seq)
    gc_count = 0
    gc_content = 0
    
    for base in seq:
        if (base == "G") or (base == "C"):
            gc_count += 1
    
    gc_content = gc_count/seq_len*100
    
    return gc_content

#To a .txt file
def to_txt(file_name, string):
    with open(file_name, 'w') as f:
        f.write(string)

#To test passing in arguments from C#
def test(string):
    print(string)