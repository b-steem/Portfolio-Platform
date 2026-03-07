import { test, expect } from '@playwright/test';

test('navbar links navigate to sections', async ({ page }) => {
    await page.goto('/');
    
    const navbarSection = page.locator('#navbar');
    await navbarSection.getByRole('link', { name: 'Projects' }).click();

    await expect(page.locator('#projects')).toBeInViewport();
});

test('contact link scrolls to contact section', async ({ page }) => {
    await page.goto('/');
    
    const navbarSection = page.locator('#navbar');
    await navbarSection.getByRole('link', { name: /contact/i }).click();

    await expect(page.locator('#contact')).toBeInViewport();
});