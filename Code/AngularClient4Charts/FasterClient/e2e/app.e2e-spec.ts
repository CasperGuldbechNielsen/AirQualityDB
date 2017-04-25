import { FasterClientPage } from './app.po';

describe('faster-client App', () => {
  let page: FasterClientPage;

  beforeEach(() => {
    page = new FasterClientPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
