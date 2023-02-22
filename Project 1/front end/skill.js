async function addUser() {
    const handleeducation = document.getElementById("addskill");

    handleeducation.addEventListener("submit", event => {
        event.preventDefault();
    });

    let userid = localStorage.getItem('skillid')

    let TrainerIds1 = document.getElementById("TrainerIds").value;
    let SkillsId1 = document.getElementById("SkillsIds").value;
    let Skills11 = document.getElementById("Skills1s").value;
    let Skills21 = document.getElementById("Skills2s").value;
    let Certificate1 = document.getElementById("Certificates").value;
   


    await fetch("https://localhost:7228/api/Skill/FetchSkill",
        {
            method: "POST",
            body: JSON.stringify({
                "trainerId": TrainerIds1,
                "SkillsId": SkillsId1,
                "Skills1": Skills11,
                "Skills2": Skills21,
                "Certificate": Certificate1,
                

            }),
            headers: {
                "Content-type": "application/json; charset=UTF-8",
            },
        })
        .then((response) => console.log(response))
    alert("added User Details!")
    //window.location.href = "view.html"
}