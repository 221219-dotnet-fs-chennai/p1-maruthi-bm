async function addUser() {
    const handleeducation = document.getElementById("addEducation");

    handleeducation.addEventListener("submit", event => {
        event.preventDefault();
    });

    let TrainerIds1 = document.getElementById("TrainerIds").value;
    let EducationId1 = document.getElementById("EducationIds").value;
    let Degree1 = document.getElementById("Degrees").value;
    let InstituteName1 = document.getElementById("InstituteNames").value;
    let StartDate1 = document.getElementById("StartDates").value;
    let EndDate1 = document.getElementById("EndDates").value;
    let Grade1 = document.getElementById("Grades").value;
    let Cgpa1 = document.getElementById("Cgpas").value;
   


    await fetch("https://localhost:7228/api/Education/Adduser",
        {
            method: "POST",
            body: JSON.stringify({
                "trainerId": TrainerIds1,
                "educationId": EducationId1,
                "degree": Degree1,
                "instituteName": InstituteName1,
                "startDate": StartDate1,
                "endDate": EndDate1,
                "grade": Grade1,
                "cgpa": Cgpa1
                

            }),
            headers: {
                "Content-type": "application/json; charset=UTF-8",
            },
        })
        .then((response) => console.log(response))
    alert("added User Details!")
    //window.location.href = "view.html"
}