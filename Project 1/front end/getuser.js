const signinform = document.getElementById("showUserDetail");


var id = localStorage.getItem("userid");
// email = email.replace(/['‘’"“”]/g, '')
// console.log(email);


fetch(`https://localhost:7228/api/User/FetchUser/${id}`,
{
    method: "GET",
    headers: {
        "Context-type": "application.json; charset=UTF-8",
    },
})
// .then((response) => console.log(response))
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

            const first_name = document.createElement('p')
            first_name.textContent = "Name :- "+ element.name
            first_name.className = "card_user_first_name"

            const address = document.createElement('p')
            address.textContent = "Address :- "+ element.address
            address.className = "card_user_address"

            const age = document.createElement('p')
            age.textContent = "Age :- " + element.age
            age.className = "card_user_age"

            const password = document.createElement('p')
            password.textContent = "password :- " + element.password
            password.className = "card_user_password"

            const gender = document.createElement('p')
            gender.textContent = "gender :- "+ element.gender
            gender.className = "card_user_gender"

            const location = document.createElement('p')
            location.textContent = "location :- " + element.location
            location.className = "card_user_location"

            const domain = document.createElement('p')
            domain.textContent = "domain :- " + element.domain
            domain.className = "card_user_domain"

            console.log(id)



            div.appendChild(user_id)
            div.appendChild(first_name)
            div.appendChild(address)
            div.appendChild(age)
            div.appendChild(password)
            div.appendChild(gender)
            div.appendChild(location)
            div.appendChild(domain)

    


            signinform.appendChild(div)
})
