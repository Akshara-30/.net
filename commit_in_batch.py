from os import walk
import subprocess
import os

filenames = []

for dirpath, dirnames, files in walk("."):
    for file in files:
        # Get the full path of each file
        file_path = os.path.join(dirpath, file)
        # Convert Windows backslashes to forward slashes for git
        file_path = file_path.replace('\\', '/')
        if ".git" not in file_path:
            filenames.append(file_path)

# print(filenames)

total_file_count = len(filenames)
print(total_file_count)

batch_size = 10
page_size = int(total_file_count / batch_size)
page = 0

for i in range(0, page_size):
    files = filenames[page * batch_size: (page + 1) * batch_size]
    files_list = ' '.join(files)
    print(f"Committing files -> from: {(page * batch_size) + 1} to {(page + 1) * batch_size}")
    # subprocess.call(["git", "add", files_list])    
    cmd = "git add " + files_list
    os.system(cmd)
    os.system("git commit -m" + f"\"Batch commit {page + 1}\"")
    # os.system("git push origin main")
    page += 1    

