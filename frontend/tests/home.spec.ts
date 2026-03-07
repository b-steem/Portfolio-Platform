import { test, expect } from '@playwright/test';

test('hero section displays profile information', async ({ page }) => {
  await page.goto('/');

  const heroSection = page.locator('#home');
  await expect(heroSection.getByRole('heading', { name: 'Bennet Steem' })).toBeVisible();
  await expect(page.locator('#home')).toBeVisible();
});