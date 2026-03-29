body {
  font-family: Arial, sans-serif;
  margin: 0;
  padding: 20px;
  background-color: #fff;
  color: #333;
  transition: background-color 0.3s, color 0.3s;
}

h1 {
  text-align: center;
}

button {
  padding: 10px 20px;
  margin: 10px 0;
  cursor: pointer;
  border: none;
  border-radius: 5px;
  transition: background-color 0.3s;
}

#darkModeBtn {
  display: block;
  margin: 20px auto;
  background-color: #3498db;
  color: white;
}

#darkModeBtn:hover {
  background-color: #2980b9;
}

.content p {
  margin-bottom: 20px;
  line-height: 1.6;
}

/* Scroll to Top Button */
#scrollTopBtn {
  position: fixed;
  bottom: 30px;
  right: 30px;
  display: none; /* hidden by default */
  background-color: #e74c3c;
  color: white;
  padding: 10px 15px;
  border-radius: 50%;
  font-size: 18px;
}

#scrollTopBtn:hover {
  background-color: #c0392b;
}

/* Dark mode styles */
body.dark-mode {
  background-color: #1e1e1e;
  color: #f1f1f1;
}

body.dark-mode #darkModeBtn {
  background-color: #f39c12;
  color: #1e1e1e;
}

body.dark-mode #darkModeBtn:hover {
  background-color: #e67e22;
}

body.dark-mode #scrollTopBtn {
  background-color: #f39c12;
  color: #1e1e1e;
}

body.dark-mode #scrollTopBtn:hover {
  background-color: #e67e22;
}
