// Dark Mode Toggle
const darkModeBtn = document.getElementById('darkModeBtn');
darkModeBtn.addEventListener('click', () => {
  document.body.classList.toggle('dark-mode');
  if (document.body.classList.contains('dark-mode')) {
    darkModeBtn.textContent = 'Light Mode';
  } else {
    darkModeBtn.textContent = 'Dark Mode';
  }
});

// Scroll-to-Top Button
const scrollTopBtn = document.getElementById('scrollTopBtn');

// Show button when user scrolls down
window.addEventListener('scroll', () => {
  if (window.scrollY > 300) { // show after scrolling 300px
    scrollTopBtn.style.display = 'block';
  } else {
    scrollTopBtn.style.display = 'none';
  }
});

// Smooth scroll to top when clicked
scrollTopBtn.addEventListener('click', () => {
  window.scrollTo({ top: 0, behavior: 'smooth' });
});
