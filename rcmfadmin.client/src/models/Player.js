export class Player {
  constructor(data) {
    this.id = data.id;
    this.name = data.name
    this.email = data.email // NOTE optional
    this.shirtSize = data.shirtSize //NOTE Enum

  }
}

