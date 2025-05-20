// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function setActiveStyle(themeId) {
    const themes = ['creamTheme', 'pinkTheme', 'blackTheme'];
    themes.forEach(id => {
        const link = document.getElementById(id);
        if (link) link.disabled = (id !== themeId);
    });
    // Зберігаємо вибір користувача
    localStorage.setItem('selectedTheme', themeId);
}

// Завантажуємо збережену тему при старті
document.addEventListener('DOMContentLoaded', () => {
    const savedTheme = localStorage.getItem('selectedTheme') || 'creamTheme';
    setActiveStyle(savedTheme);
});