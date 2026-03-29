// Select elements
const animalName = document.getElementById('animalName');
const welcomeMessage = document.getElementById('welcomeMessage');

// Original and nickname
const originalName = "Elephant";
const nickname = "Big E";

// Change name on mouse hover
animalName.addEventListener('mouseover', () => {
  animalName.textContent = nickname;
});

// Revert name when mouse leaves
animalName.addEventListener('mouseout', () => {
  animalName.textContent = originalName;
});

// Show welcome message after 3 seconds
setTimeout(() => {
  welcomeMessage.textContent = "Welcome to the Animal Page!";
}, 3000);
