@import url('https://fonts.googleapis.com/css2?family=Montserrat+Subrayada:wght@400;700&family=Montserrat:wght@300&display=swap');

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: "montserrat";
    color: #fff;
  }
  
  html,
  body {
    height: 100%;
  
    width: 100%;
  }
  .nav-bar {
    background-color: whitesmoke;
    height:50px;
    width: 100%;
    position: fixed;
    top: 0;
    left: 0;
    z-index: 1000;
    display: flex;
    justify-content: center;
    align-items: center;
    
  }
  
  .logo {
    height: 80px;
    width: 80px;
    margin-top: 58px;
    
  }

  .nav-items ul {
    display: flex;
    list-style: none;
    font-size: 12px;
    font-weight: 500;
  
    color: #000;
}

.nav-items ul li {
    margin: 0 20px; /* Adjust margin as needed */
}

.nav-items ul li a {
    text-decoration: none;
    color: #000;
}

.nav-items ul li a:hover {
    color: #000;
}

@media (max-width: 768px) {
  .nav-bar {
      height: 60px; /* Adjust height for mobile */
  }

  .logo {
      height: 60px;
      width: 60px;
      margin-top: 40px;
  }

  .nav-items ul {
      font-size: 10px;
  }

  .nav-items ul li {
      margin: 0 5px; /* Adjust margin for mobile */
  }
}

.search{
  margin-left: 33px;



}



.cart{
  margin-left: 30px;

}

/* Your existing CSS code here */

.nav2 {
  position: fixed;
  top: 50px; /* Adjust for the height of the nav-bar */
  width: 100%;
  height: 50px;
  background-color: white;
  display: flex;
  align-items: center;
  z-index: 1000;
  transition: background-color 0.3s ease, box-shadow 0.3s ease;
}

.nav2 h2 {
  margin-left: 10%; /* Adjust as needed */
  font-size: 18px;
  font-weight: 500;
  color: black;
  font-family: sans-serif;
}

.nav2-items{
  margin-left: 10%;
  display: flex;
  align-items: center;

}

.nav-items ul{
  display: flex;
  list-style: none;
  font-size: 12px;
  font-weight: 500;
  color: #000;

}