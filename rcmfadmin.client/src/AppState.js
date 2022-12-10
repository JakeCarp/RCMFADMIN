import { reactive } from 'vue'

// NOTE AppState is a reactive object to contain app level data
export const AppState = reactive({
  user: {},
  account: {},
  loader: 0,
  members: [],
  activeImage: null,
  donationTotal: 0,
  monthTotal: 0,
  /** @type {import('./models/Newsletter.js').Newsletter.js[]} */
  newsletterSubscribers: [],
  /** @type {import('./models/Grant.js').Grant.js[]} */
  grants: [],

  /** @type {import('./models/Donor.js').Donor.js[]} */
  donors: [],
  /** @type {import('./models/Donor.js').Donor.js | null} */
  activeDonor: null,
  /** @type {import('./models/Sponsor.js').Sponsor.js[]} */
  sponsors: [],
  /** @type {import('./models/Sponsor.js').Sponsor.js | null} */
  activeSponsor: null,
  /** @type {import('./models/Player.js').Player.js[]} */
  players: [],
  /** @type {import('./models/Team.js').Team.js[]} */
  teams: [],

  photos: [],

  loading: false,
  shirtSizes: ["XS", "Small", "Medium", "Large", "XL", "XXL", "XXXL"],
});
