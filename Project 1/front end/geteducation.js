const signinform = document.getElementById("showEducationDetail");


var id = localStorage.getItem("userid");
// email = email.replace(/['‘’"“”]/g, '')
// console.log(email);


fetch(`https://localhost:7228/api/Education/FetchUser/${id}`,
{
    method: "GET",
    headers: {
        "Context-type": "application.json; charset=UTF-8",
    },
})
//.then((response) => console.log(response))
.then((response) =>response.json())
.then(element => {
    const parentDiv = document.createElement('div')
            parentDiv.className = "container"

            const div = document.createElement('div')
            div.className = "card"

            div.appendChild(document.createElement('hr'))



            const user_id = document.createElement('p')
            user_id.textContent = "Trainer-Id :- " + element.trainerId
            user_id.className = "card_user_user_id"

            const EducationId = document.createElement('p')
            EducationId.textContent = "EducationId :- " + element.educationId
            EducationId.className = "card_user_EducationId"
            
            const Degree = document.createElement('p')
            Degree.textContent = "Degree :- "+ element.degree
            Degree.className = "card_user_Degree"

            const instituteName = document.createElement('p')
            instituteName.textContent = "instituteName :- "+ element.instituteName
            instituteName.className = "card_user_instituteName"

            const startDate = document.createElement('p')
            startDate.textContent = "startDate :- " + element.startDate
            startDate.className = "card_user_startDate"

            const endDate = document.createElement('p')
            endDate.textContent = "endDate :- "+ element.endDate
            endDate.className = "card_user_endDate"

            const grade = document.createElement('p')
            grade.textContent = "grade :- " + element.grade
            grade.className = "card_user_grade"

            const cgpa = document.createElement('p')
            cgpa.textContent = "cgpa :- " + element.cgpa
            cgpa.className = "card_user_cgpa"

            console.log(id)



            div.appendChild(user_id)
            div.appendChild(EducationId)
            div.appendChild(Degree)
            div.appendChild(instituteName)
            div.appendChild(startDate)
            div.appendChild(endDate)
            div.appendChild(grade)
            div.appendChild(cgpa)

    


            signinform.appendChild(div)
})
