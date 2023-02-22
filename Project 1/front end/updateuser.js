function modifyUser(){
    let id = localStorage.getItem('userid')
    console.log(id)

    let flag = false;
    if(id != null){
        flag= true
    }
    if(flag == true){
        handleUpdate();
    }
    }
    function handleUpdate(){
        let id = localStorage.getItem('userid')
        
    
        let TrainerIds1 = document.getElementById("TrainerIds").value;
        let Names1 = document.getElementById("Names").value;
        let Addresss1 = document.getElementById("Addresss").value;
        let Ages1 = document.getElementById("Ages").value;
        let Passwords1 = document.getElementById("Passwords").value;
        let Genders1 = document.getElementById("Genders").value;
        let Locations1 = document.getElementById("Locations").value;
        let Domains1 = document.getElementById("Domains").value;
    
    
         fetch(`https://localhost:7228/api/User/Update?`+ new URLSearchParams({
            id : id,
        }),
            {
                method: "PUT",
                body: JSON.stringify({
                    "trainerId": TrainerIds1,
                    "name": Names1,
                    "address": Addresss1,
                    "age": Ages1,
                    "password": Passwords1,
                    "gender": Genders1,
                    "location": Locations1,
                    "domain": Domains1
    
                }),
                headers: {
                    "Content-type": "application/json; charset=UTF-8",
                },
            })
            .then((response) => console.log(response))
            window.location.href = "view.html"

        // alert("Updated Successfully!")
        // .then((response) => console.log(response))
        // if(response.status === 200){
        //     alert("updated!")
        //     window.location.href = "view.html"
        // }else{
        //     alert("something went wrong")
        // }
}