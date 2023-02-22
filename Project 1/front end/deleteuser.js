async function deleteUser(){
    const handledelete = document.getElementById("deleteUser");

    handledelete.addEventListener("submit" , event =>{
        event.preventDefault();
    });

    let id = localStorage.getItem('userid')

    await fetch (`https://localhost:7228/api/User/Delete?` + new URLSearchParams({
        id : id,
    }),{
        method : "DELETE",
        headers :{
            "Content-type": "application/json; charset=UTF-8",
        },
    })
    .then((response) =>{
        if(response.status == 200){
            alert("Deleted Successfully!");
            window.location.href = "Login.html";
        }
        else{
            alert("Degree is not present");
            //window.location.href = "DeleteEdu.html";
        }
    })
    .then((response)=> console.log(response))
}