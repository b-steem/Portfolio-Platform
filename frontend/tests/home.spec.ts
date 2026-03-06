import { test, expect } from '@playwright/test';

test('home page loads', async ({ page }) => {
  await page.goto('http://localhost:4200');
  await expect(page.locator('body')).toBeVisible();
});