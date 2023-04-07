import json

with open("data.json","r") as f:
  data = f.readlines()
  res = json.loads("".join(data))

  # print( res["name"] )
  for n in range(len( res["dependencies"] ) ):
    publisher = res["dependencies"][n]["publisher"]
    name = res["dependencies"][n]["name"]
    version = res["dependencies"][n]["version"]
    print(publisher + "_" + name + "_" + version + ".app");
