async function addUser() {
    const handleeducation = document.getElementById("addUser");

    handleeducation.addEventListener("submit", event => {
        event.preventDefault();
    });


    let TrainerIds1 = document.getElementById("TrainerIds").value;
    let Names1 = document.getElementById("Names").value;
    let Addresss1 = document.getElementById("Addresss").value;
    let Ages1 = document.getElementById("Ages").value;
    let Passwords1 = document.getElementById("Passwords").value;
    let Genders1 = document.getElementById("Genders").value;
    let Locations1 = document.getElementById("Locations").value;
    let Domains1 = document.getElementById("Domains").value;


    await fetch("https://localhost:7228/api/User/AddUser?",
        {
            method: "POST",
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
    alert("added User Details!")
    //window.location.href = "view.html"
}