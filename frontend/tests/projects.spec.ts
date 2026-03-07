import { test, expect } from '@playwright/test';

test('projects section loads project cards', async ({ page }) => {
    await page.goto('/');

    await expect(page.locator('#projects')).toBeVisible();
    await expect(page.locator('.project-card').first()).toBeVisible();
});