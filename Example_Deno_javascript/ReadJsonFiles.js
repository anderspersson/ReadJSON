export {};
/*
  ReadJsonFiles
  Reads a Jason struncture file and prints it contest to the screen

  Run:
    deno run --allow-read ReadJsonFiles.js

  Bygg:
    deno compile --allow-read ReadJson.js

  (C) 2022 Anders Persson
*/

let projectName = Deno.args[0];
projectName = ".";

const fullPath = projectName + String.raw`\data.json`;
const text = await Deno.readTextFile(fullPath);

const data = JSON.parse(text);
console.log(data.dependencies);
console.log(data.dependencies.length);

data.dependencies.forEach((id) => {
  console.log("Publisher: ",id.publisher);
  console.log("Name: ",id.name);
  console.log("Version: ", id.version);
  console.log("\n ------ \n");
});

Deno.exit(0);
