const addBtn = document.getElementById("addBtn");
const clearBtn = document.getElementById("clearBtn");
const taskInput = document.getElementById("taskInput");
const taskList = document.getElementById("taskList");

// Add task
addBtn.addEventListener("click", function(){

    const taskText = taskInput.value.trim();

    if(taskText === ""){
        alert("Please enter a task");
        return;
    }

    const li = document.createElement("li");
    li.textContent = taskText;

    // Mark task as done when clicked
    li.addEventListener("click", function(){
        li.classList.toggle("done");
    });

    taskList.appendChild(li);
    taskInput.value = "";
});

// Clear all tasks
clearBtn.addEventListener("click", function(){
    taskList.innerHTML = "";
});