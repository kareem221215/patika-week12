<!-- Intro-->

<!--
* Thanks for reviewing my Project-README-Template! 
* 
* Read the comments for an easy step by step guide. Enjoy!
-->

<!-- Shields Section--> <!-- Optional -->

<!-- 
* Insert project shields and badges through this link https://shields.io/
* 
*
-->

<div align="center">
    <a href="https://github.com/kareem221215/patika-week12/blob/main/LICENSE.txt"><img alt="GitHub license" src="https://img.shields.io/github/license/kareem221215/patika-week12?color=ff69b4&style=for-the-badge"></a>
    <a href="https://github.com/kareem221215/patika-week12/stargazers"><img alt="GitHub stars" src="https://img.shields.io/github/stars/kareem221215/patika-week12?color=yellow&label=Project%20Stars&style=for-the-badge"></a>
    <a href=https://github.com/kareem221215/patika-week12/issues><img alt="GitHub issues" src="https://img.shields.io/github/issues/kareem221215/patika-week12?color=brightgreen&label=issues&style=for-the-badge"></a>
    <a href=https://github.com/kareem221215/patika-week12/network><img alt="GitHub forks" src="https://img.shields.io/github/forks/kareem221215/patika-week12?color=9cf&label=forks&style=for-the-badge"></a>
</div>
<br>


<!-- Logo Section  --> <!-- Required -->

<!--
* Insert your github profile URL in the <a> "href" attribute bellow (line-25)
* 
* Insert an image URL in the <img> "src" attribute bellow. (line-26)
-->
<div align="center">
    <a href="kareem221215" target="_blank"><img src="https://github.com/kareem221215/patika-projects-week2/blob/main/oie_CfqoiAfbCyTJ.png" 
        alt="Logo" height="350" width="500">
    </a>
</div>


</div>


<!-- Project title 
* use a dynamic typing-SvG here https://readme-typing-svg.demolab.com/demo/
*
*  Instead you can type your project name after a # header
-->

<div align="center">
<img src="https://readme-typing-svg.demolab.com?font=Fira+Code&size=22&duration=4000&pause=3000&background=FFFFFF00&center=true&vCenter=true&multiline=true&width=435&lines=Patika-Bootcamp-Projects!&color=ffbf5e">
</div>


## About<!-- Required -->
Welcome to the repository for the projects completed in **Week 12** of the bootcamp. This week, we covered a variety of topics and built several key projects to strengthen our skills.

<!-- 
* information about the project 
* 
* keep it short and sweet
-->



<!-- 
* Here you may add information about how 
* 
* and why to use this project.
-->
# 📌 Weekly Progress Report  

## 🏆 Focus Areas  
This week, we focused on the following key areas:  

- Implementing **Code First Approach** with Entity Framework Core  
- Establishing **database relationships** using Code First conventions  
- Building a **Web API** with CRUD operations  
- Utilizing **Postman/Swagger** to test API endpoints  

---

## 📂 Projects Included  

### **1️⃣ Project: Code First Basic**  
Created a **Code First** database using Entity Framework Core, including two independent tables:  

#### 🔹 Tables Implemented:  
- **Movies Table:** Stores movie details such as title, genre, and release year.  
- **Games Table:** Stores game details including platform and rating.  

#### 🔹 Key Features:  
- Configured **PatikaFirstDbContext** for database interactions.  
- Defined **Movie** and **Game** entities.  
- Used **migrations** to generate and update the database.  

📌 **Database Name:** `PatikaCodeFirstDb1`  
📌 **Tables Created:** `Movies`, `Games`  

---

### **2️⃣ Project: Code First Relation**  
Developed a **Code First relational database** where a **User** can create multiple **Posts**.  

#### 🔹 Tables Implemented:  
- **Users Table:** Stores user details like username and email.  
- **Posts Table:** Stores post details including title, content, and user reference.  

#### 🔹 Key Features:  
- Established a **One-to-Many Relationship** (One User → Many Posts).  
- Used **Foreign Keys** to ensure referential integrity.  
- Implemented **CRUD operations** for Users and Posts.  

📌 **Database Name:** `PatikaCodeFirstDb2`  
📌 **Tables Created:** `Users`, `Posts`  

---

### **3️⃣ Project: Survivor API**  
Built a **Web API** for a **Survivor competition system**, handling **Competitors** and **Categories** with a **One-to-Many Relationship**.  

#### 🔹 Tables Implemented:  
- **Competitors Table:** Stores competitor details (e.g., name, age, category).  
- **Categories Table:** Defines competition categories (e.g., "Strength", "Strategy").  

#### 🔹 Key Features:  
- Implemented **BaseEntity Class** for reusable entity properties.  
- Created **CompetitorController** with endpoints for:  
  - Listing all competitors  
  - Retrieving competitors by category  
  - Creating, updating, and deleting competitors  
- Created **CategoryController** with CRUD operations.  
- Tested API with **Postman/Swagger**.  

📌 **Technologies Used:** ASP.NET Core Web API, Entity Framework Core  
📌 **API Endpoints Implemented:** `/api/competitors`, `/api/categories`  

---

## ✅ Summary of Learning Outcomes  
- **Applied Entity Framework Core Code First Approach** to create databases and tables.  
- **Defined relationships** (One-to-Many) and managed **foreign keys** efficiently.  
- **Built a Web API** with RESTful endpoints and tested them using Postman.  
- **Implemented controllers** for database interactions, ensuring full CRUD functionality.  

This week significantly strengthened our understanding of **database design, ORM (Object-Relational Mapping), and API development**! 🚀  


<!--## Contents Table<!-- Optional -->
<!-- 
* This section is optional, yet having a contents table 
* helps keeping your README readable and more professional.
* 
* If you are not familiar with HTML, no worries we all been there :D 
* Review learning resources to create anchor links. 
-->


<dev align="center">
<!--<table align="center">
        <tr>
            <td><a href="#about style="text-decoration: none;">About</a></td>        
            <td><a href="#how-to-use-this-project style="text-decoration: none;">Getting started</td>
            <td><a href="#contributors style="text-decoration: none;">Contributors</a></td>
            <!--<td><a href="#demo style="text-decoration: none;">Demo</a></td>-->
            <!--<td><a href="#project-roadmap-- style="text-decoration: none;">Project Roadmap</a></td>-->
            <!--<td><a href="#documentation style="text-decoration: none;">Documentation</a></td>-->
        <!--</tr> 
        <tr>
            <!--<td><a href="#acknowledgments">Acknowledgments</a></td>-->
          <!--  <td><a href="#feedback style="text-decoration: none;">Feedback</a></td>
            <td><a href="#contact style="text-decoration: none;">Contact</a></td>
            <td><a href="#license style="text-decoration: none;">License</a></td> -->
      <!--  </tr>-->
<!--</table>
</dev> -->


<!-- - Use this html element to create a back to top button. -->
<!--<p align="right"><a href="#how-to-use-this-project">back to top ⬆️</a></p> 


<!--## Project Roadmap <!-- Optional --> <!-- add learning_Rs-->
<!-- 
* Add this section in case the project has different phases
* 
* Under production or will be updated.
-->

<!--<p align="right"><a href="#how-to-use-this-project">back to top ⬆️</a></p>-->



<!--## Documentation<!-- Optional -->
<!-- 
* You may add any documentation or Wikis here
* 
* 
-->


## Contributors<!-- Required -->
<!-- 
* Without contribution we wouldn't have open source. 
* 
* Generate github contributors Image here https://contrib.rocks/preview?repo=angular%2Fangular-ja
-->
<a href="https://github.com/kareem221215/patika-projects-week2/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=kareem221215/patika-projects-week2" />
</a>

<!--## Acknowledgments<!-- Optional -->
<!-- 
* Credit where it's do 
* 
* Feel free to share your inspiration sources, Stackoverflow questions, github repos, tools etc.
-->


<!-- - Use this html element to create a back to top button. -->
<!--<p align="right"><a href="#how-to-use-this-project">back to top ⬆️</a></p>-->


## Feedback<!-- Required -->
<!-- 
* You can add contacts information like your email and social media account 
* 
* Also it's common to add some PR guidance.
-->


> If you have any suggestions, ideas, or spot any bugs, feel free to open an issue on this repository [Create an Issue](https://github.com/kareem221215/patika-week12/issues).
- Use the tag **"Correction"** for bugs or typos.
- If you want to share any ideas to help make this project better, use the tag **"Enhancement"**.
<details>
    <summary>Contact Me 📨</summary>

### Contact<!-- Required -->
Reach me via email: [kareem.s.sleman@gmail.com](mailto:kareem.s.sleman@gmail.com)
<!-- 
* add your email and contact info here
* 
* 
-->
</details>

## License<!-- Optional -->
<!-- 
* Here you can add project license for copyrights and distribution 
* 
* check this website for an easy reference https://choosealicense.com/)
-->
- [MIT License](../LICENSE.txt)

<!-- - Use this html element to create a back to top button. -->
<p align="right"><a href="#how-to-use-this-project">back to top ⬆️</a></p>
