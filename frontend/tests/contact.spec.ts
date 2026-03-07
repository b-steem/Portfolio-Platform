import { test, expect } from '@playwright/test';

test('contact section displays contact cards', async ({ page }) => {
  await page.goto('/');

  await expect(page.locator('#contact')).toBeVisible();
  await expect(page.locator('.contact-card').first()).toBeVisible();
});