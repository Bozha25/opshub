const modules = [
  {
    name: "Roaming",
    description: "Roaming requests, carrier email drafts and return-date reminders",
  },
  {
    name: "Devices",
    description: "Device register, status lifecycle, CSV import and dashboards",
  },
  {
    name: "Dynamic Tables",
    description: "Configurable tables with custom fields, actions and search",
  },
];

export default function Home() {
  return (
    <main className="mx-auto flex w-full max-w-4xl flex-1 flex-col gap-10 px-6 py-16">
      <header className="flex flex-col gap-2">
        <h1 className="text-3xl font-semibold tracking-tight">OpsHub</h1>
        <p className="text-zinc-600 dark:text-zinc-400">
          Internal tools for IT operations teams
        </p>
      </header>

      <ul className="grid gap-4 sm:grid-cols-3">
        {modules.map((m) => (
          <li
            key={m.name}
            className="rounded-lg border border-zinc-200 p-5 dark:border-zinc-800"
          >
            <h2 className="font-medium">{m.name}</h2>
            <p className="mt-1 text-sm text-zinc-600 dark:text-zinc-400">
              {m.description}
            </p>
          </li>
        ))}
      </ul>
    </main>
  );
}